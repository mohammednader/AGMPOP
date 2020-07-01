const CACHE_STATIC_NAME = "static-v2";
const CACHE_DYNAMIC_NAME = "dynamic-v2";
const CACHE_DYNAMIC_MAX = 25;

const STATIC_FILES = [
    '/Offline.html',
    '/manifest.json',
];

String.prototype.isStatic = function () {
    var url = new URL(this);
    for (let file of STATIC_FILES) {
        if (url.origin === location.origin) {
            if (url.pathname.toLowerCase() === file.toLowerCase()) {
                return true;
            }
        }
        else {
            if (this.toLowerCase() === file.toLowerCase()) {
                return true;
            }
        }
    }
    return false;
}

const precache = async () => {
    const cache = await caches.open(CACHE_STATIC_NAME);
    return cache.addAll(STATIC_FILES).catch(_ => {});
};

const trimCache = async (cacheName, maxItems) => {
    const cache = await caches.open(cacheName);
    const keys = await cache.keys();
    if (keys.length > maxItems) {
        await cache.delete(keys[0]);
        await trimCache(cacheName, maxItems);
    }
};

const updateCache = async () => {
    try {
        const keyList = await caches.keys();
        return Promise.all(
            keyList.map(key => {
                if (key !== CACHE_STATIC_NAME && key !== CACHE_DYNAMIC_NAME) {
                    return caches.delete(key);
                }
            })
        );
    } catch (_) { }
};

const cacheOnly = request => {
    return caches.match(request);
};

const cacheFirst = request => {
    return caches.match(request)
        .then(cacheResponse => {
            if (cacheResponse) {
                return cacheResponse;
            }
            else {
                return fetchAndSave(request)
                    .then(response => response)
                    .catch(_ => {
                        if (request.headers && request.headers.get("accept").includes("text/html")) {
                            return caches.match("/Offline.html").then(response => {
                                return response || new Response(null);
                            });
                        }
                        else {
                            return new Response(null);
                        }
                    });
            }
        }).catch(_ => {
            return new Response(null);
        });
};

const networkFirst = request => {
    return fetchAndSave(request)
        .then(response => response)
        .catch(_ => {
            return cacheOnly(request).then(response => {
                if (response) {
                    return response;
                }
                else if (request.headers && request.headers.get("accept").includes("text/html")) {
                    return caches.match("/Offline.html").then(response => {
                        return response || new Response(null);
                    });
                }
                else {
                    return new Response(null);
                }
            });
        });
}

const fetchAndSave = request => {
    return fetch(request)
        .then(networkResponse => {
            return caches.open(CACHE_DYNAMIC_NAME).then(cache => {
                cache.put(request, networkResponse.clone());
                trimCache(CACHE_DYNAMIC_NAME, CACHE_DYNAMIC_MAX);
                return networkResponse;
            });
        });
}

self.addEventListener("install", async event => {
    self.skipWaiting();
    event.waitUntil(precache());
});

self.addEventListener("activate", event => {
    event.waitUntil(updateCache());
    return self.clients.claim();
});

self.addEventListener("fetch", event => {
    if (event.request.method.toLowerCase() === "get") {
        if (event.request.url.isStatic()) {
            event.respondWith(cacheFirst(event.request));
        }
        else {
            event.respondWith(networkFirst(event.request));
        }
    }
    //if (event.request.url.isStatic()) {
    //    event.respondWith(cacheOnly(event.request));
    //} else {
    //    event.respondWith(cacheFirst(event.request));
    //}
});