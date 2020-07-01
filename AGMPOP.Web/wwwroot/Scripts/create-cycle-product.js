var Products = [];

var FilteredProducts = Products;

var SelectedProductIds = [];

var selectedProductType = 0, selectedProductDepartment = 0;

const PRODUCT_MARKUP = `<div class="list-group-item d-flex align-items-center">
                                <img src="#IMAGE#" style="width:30px; height:30px; border-radius:50%" class="mr-2"/>
                                <span class="ml-2">#NAME#</span>
                                <span class="form-check ml-auto">
                                    <input type="checkbox" class="form-check-input chkProduct" #DISABLED# #CHECKED# id="chkProduct-#ID#" onchange="toggleSelectProduct(this)" />
                                    <label class="form-check-label" for="chkProduct-#ID#"></label>
                                </span>
                            </div>`;

const NO_PRODUCT_MARKUP = '<div class="list-group-item d-flex justify-content-center">No products found</div>';

const PRODUCT_TYPE_MARKUP = '<button onclick=searchProductType(#ID#) class="btn btn-link p-0">#NAME#</button>';

const SELECTED_PRODUCT_MARKUP = `<div data-product="#ID#" style="#DISABLED#" class="list-group-item px-1 py-1 selected-product-item">
                                <div class="d-flex align-items-center">
                                    <img src="#IMAGE#" style="width:20px; height:20px; border-radius:50%" class="mr-2"/> 
                                    <span class="font-small" style="max-width: 30ch; text-overflow:ellipsis">#NAME# <small class="text-secondary"> </small></span>
                                    <div style="display:#HIDE_QUANTITY#" class="form-group ml-auto my-0">
                                        <input type="number" min="1" max="#MAX#" value="#QTY#" class="txtQuantity" style="max-width: 7ch;" id="txtQuantity-#ID#" />
                                        
                                    </div>
                                    <button onclick="removeProduct(#ID#)" class="btn btn-link text-dark ml-1 mr-0 px-0"><i style="transform:scale(1.2);#DISPLAY#" class="fa fa-times-circle"></i></button>
                                </div>
                                <p class="text-danger text-center my-0" id="errQuantity-#ID#"></p>
                            </div>`;


function getAllProducts(skipSelected = false) {
    let url = '/Cycles/GetAllProducts?';
    if (!skipSelected && CycleId) {
        url += `cycleId=${CycleId}&`
    }
    if (CycleDepartment) {
        url += `department=${CycleDepartment}`
    }
    $.ajax({
        url,
        method: 'GET',
        success: response => {
            Products = response.items || [];
            if (!CycleId) {
                Products = Products.filter(p => p.maxQuantity > 0);
            }
            if (!skipSelected) {
                let hideQuantity = false;
                if (CycleId && Products.filter(p => p.selected).every(p => p.quantity == 0)) {
                    hideQuantity = true;
                }
                Products.filter(p => p.selected).forEach(e => {
                    if (SelectedProductIds.indexOf(e.id) == -1) {
                        addProduct(e.id, e.quantity, hideQuantity);
                    }
                });
            }
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
        .filter(p => (selectedProductType == 0 || p.typeId == selectedProductType)
            && (selectedProductDepartment == 0 || p.departmentId == selectedProductDepartment));

    viewProducts(FilteredProducts);
}

function viewProducts(products) {
    $('#lstProducts').empty();
    if (products.length) {
        $('#productCount').text(`${products.length} items`);
        $('#productCount').show();
        for (let product of products) {
            let markup = PRODUCT_MARKUP
                .replace(/#ID#/g, product.id)
                .replace(/#NAME#/g, product.name)
                .replace(/#IMAGE#/g, product.image)
                //.replace(/#TYPE#/g, product.typeName);
            if (SelectedProductIds.indexOf(product.id) != -1) {
                markup = markup.replace(/#CHECKED#/g, "checked");
            } else {
                markup = markup.replace(/#CHECKED#/g, "");
            }
            if (CycleId) {
                markup = markup.replace(/#DISABLED#/g, "disabled")
            } else {
                markup = markup.replace(/#DISABLED#/g, "")
            }

            $('#lstProducts').append(markup);
        }
    } else {
        $('#lstProducts').append(NO_PRODUCT_MARKUP);
        $('#productCount').hide();
    }
}

function clearFilterProducts() {
    selectedProductType = 0;
    selectedProductDepartment = 0;
    getAllProducts(skipSelected = true);
}

function searchProductType(typeId) {
    selectedProductType = typeId;
    filterProducts();
}

function searchProductDepartment(departmentId) {
    selectedProductDepartment = departmentId;
    filterProducts();
}

function searchTextProducts(text) {
    var list = FilteredProducts.filter(p => !text || p.name.toLowerCase().indexOf(text.toLowerCase()) != -1);
    viewProducts(list);
}

function toggleSelectProduct(element) {
    var id = element.id.split('-')[1];
    if (!isNaN(id)) {
        if (element.checked) {
            addProduct(id);
        } else {
            removeProduct(id);
        }
    }
}

function addProduct(id, qty = 1, hideQuantity = false) {
    product = Products.find(p => p.id == id);
    id = parseInt(id);
    if (product) {
        SelectedProductIds.push(id);
        product.quantity = qty || 1;
        var markup = SELECTED_PRODUCT_MARKUP
            .replace(/#ID#/g, id)
            .replace(/#NAME#/g, product.name)
            .replace(/#IMAGE#/g, product.image)
            .replace(/#MAX#/g, product.maxQuantity)
            .replace(/#QTY#/g, product.quantity);

        if (CycleId) {
            markup = markup.replace(/#DISPLAY#/g, "display:none");
            markup = markup.replace(/#DISABLED#/g, "pointer-events:none");
        } else {
            markup = markup.replace(/#DISPLAY#/g, "");
            markup = markup.replace(/#DISABLED#/g, "");
        }
        if (hideQuantity) {
            markup = markup.replace(/#HIDE_QUANTITY#/g, "none");
        } else {
            markup = markup.replace(/#HIDE_QUANTITY#/g, "");
        }
        $('#lstSelectedProducts').append(markup);

        $('#selectedProductsCount').text(SelectedProductIds.length);
    }
}

function removeProduct(id) {
    SelectedProductIds = SelectedProductIds.filter(e => e != id);
    $('#selectedProductsCount').text(SelectedProductIds.length);

    $(`.selected-product-item[data-product=${id}]`).remove();
    $(`#chkProduct-${id}`).prop('checked', false);
}

function validateQuantity(element) {
    var qty = element.value;
    var id = element.id.split('-')[1];
    element.style.borderColor = "";
    $(`#errQuantity-${id}`).text('');
    if (!isNaN(id) && !isNaN(qty)) {
        var product = Products.find(p => p.id == id);
        if (product) {
            if (element && element.value <= 0) {
                $(element).addClass('shake-element');
                setTimeout(() => {
                    $(element).removeClass('shake-element');
                }, 500);
                element.style.borderColor = "red";
                qty = null;
            }
            else if (qty > product.maxQuantity) {
                $(`#errQuantity-${id}`).text(`maximum: ${product.maxQuantity}`);
                setTimeout(() => {
                    $(`#errQuantity-${id}`).text('');
                }, 1000);
                qty = product.maxQuantity;
            }
            else {
                qty = parseInt(element.value);
            }
            element.value = qty;
            product.quantity = qty;
        }
    }
}

function getSelectedProducts(e) {
    return Products.filter(p => SelectedProductIds.indexOf(p.id) != -1);
}

function validateCycleProducts() {
    var products = getSelectedProducts();
    if (products && products.length) {
        if (products.some(p => !p.quantity)) {
            return null;
        }
        return products.map(p => {
            return {
                id: p.id,
                quantity: p.quantity,
            };
        });
    }
    else {
        Swal.fire({
            icon: 'warning',
            text: 'No products selected',
        });
        return null;
    }
}

function resetSelectedProducts() {
    SelectedProductIds = [];
}