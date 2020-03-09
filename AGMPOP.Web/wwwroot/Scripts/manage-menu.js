function manageMenu(permissions) {
    if (!permissions) {
        return;
    }
    var url = location.pathname;
    expandedPermissions = [];
    permissions.forEach(p => {
        expandedPermissions.push(p);
        p["children"].forEach(c => expandedPermissions.push(c));
    });
    var permission = expandedPermissions.find(p => p["permissionUrl"] && p["permissionUrl"].toLowerCase() == url.toLowerCase());
    if (permission) {
        var node = document.getElementById(permission["activeId"]);

        if (permission["parentId"] > 0) {
            var parent = expandedPermissions.find(p => p["id"] == permission["parentId"]);
            if (parent) {
                var parentNode = document.getElementById(parent["activeId"]);

                var parentShowElement = document.getElementById(parent["showId"]);
            }

        }
        if (node) {
            $(node).find('a').css('color', 'greenyellow');
        }

        if (parentNode) {
            parentNode.classList.add("active");
            $(parentNode).find('.sidebar-submenu').css('display', 'block');
        }
        if (parentShowElement) {
            parentShowElement.classList.add("show");
        }
    }
    else if (url === '/') {
        $('#home-li').addClass('active');
        $('#home-li').find('span').css('color', 'greenyellow');
    }
}