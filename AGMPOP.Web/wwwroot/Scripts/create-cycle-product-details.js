var Products = [];

var FilteredProducts = Products;

var selectedProductType = 0;

const PRODUCT_MARKUP = `<div class="list-group-item d-flex align-items-center row">
                                <span style="display:#HIDE_QUANTITY#" class="col-2 border-right">#QUANTITY#</span>
                                <span class="col-6 pl-2">#NAME#</span>
                                <span class="col-4 form-check ml-auto text-right">
                                    <a class="btn btn-warning" for="tras-#ID#" href="/Report/transactionIndex?productName=#NAME#&cycleName=#CycleName#" target="_blank">transaction</a>
                                </span>
                            </div>`;

const NO_PRODUCT_MARKUP = '<div class="list-group-item d-flex justify-content-center">No products found</div>';

const PRODUCT_TYPE_MARKUP = '<button onclick=searchProductType(#ID#) class="btn btn-link p-0">#NAME#</button>';


function getAllProducts() {
    var CycleId = $("#cyceleId").val();

    let url = '/Cycles/GetAllProductsCycleDetails?';
    if (CycleId) {
        url += `cycleId=${CycleId}&`
    }
    $.ajax({
        url,
        method: 'GET',
        success: response => {
            Products = response || [];
            filterProducts();
        }
    });
}

function getAllProductTypes() {
    $.ajax({
        url: '/Common/GetAllProductTypes',
        method: 'GET',
        success: response => {
            if (response && response.length) {
                $('#lstProductTypes').empty();
                for (let d of response) {
                    let markup = PRODUCT_TYPE_MARKUP
                        .replace(/#ID#/g, d.id)
                        .replace(/#NAME#/g, d.name);
                    $('#lstProductTypes').append(markup);
                }
                $('#divProductTypeSearch').css('display', 'flex');
            } else {
                $('#divProductTypeSearch').hide();
            }
        },
    });
}


function filterProducts() {
    FilteredProducts = Products
        .filter(p => selectedProductType == 0 || p.typeId == selectedProductType);

    viewProducts(FilteredProducts);
}

function viewProducts(products) {
    var CycleName = $("#cycleName").val();
    $('#lstProducts').empty();
    if (products.length) {
        $('#productCount').text(`${products.length} items`);
        $('#productCount').show();
        let hideQuantity = false;
        if (products.every(p => p.quantity == 0)) {
            hideQuantity = true;
        }
        for (let product of products) {
            let markup = PRODUCT_MARKUP
                .replace(/#ID#/g, product.id)
                .replace(/#NAME#/g, product.name)
                .replace(/#QUANTITY#/g, product.quantity)
                .replace(/#CycleName#/g, CycleName)
                //.replace(/#TYPE#/g, product.typeName || "");
            if (hideQuantity) {
                markup = markup.replace(/#HIDE_QUANTITY#/g, "none");
            } else {
                markup = markup.replace(/#HIDE_QUANTITY#/g, "");
            }

            $('#lstProducts').append(markup);
        }
    } else {
        $('#lstProducts').append(NO_PRODUCT_MARKUP);
        $('#productCount').hide();
    }
}

function clearFilterProducts() {
    selectedProductDepartment = 0;
    selectedProductType = 0;
    getAllProducts(skipSelected = true);
}

function searchProductType(typeId) {
    selectedProductType = typeId;
    filterProducts();
}

function searchTextProducts(text) {
    var list = FilteredProducts.filter(p => !text || p.name.toLowerCase().indexOf(text.toLowerCase()) != -1);
    viewProducts(list);
}