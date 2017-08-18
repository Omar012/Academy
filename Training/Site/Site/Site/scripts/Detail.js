$(document).ready(function () {
    loadProduct();
});

function loadProduct() {
    var myProduct = FindMyProduct(getJsonFromUrl())
    buildMyProduct(myProduct);
}

function FindMyProduct(id) {
    var ProductDetails = "";
    $.each(JSONDetails, function (element, object) {
        if (object.id == id)
            ProductDetails = object;
    });
    return ProductDetails;
}

//Dynamic build your collection
function buildMyProduct(product) {
    var html = "<div class='row'><div class='col-xs-12'>";
    html += "<div>" + product + "</div>";
    html += "<div class='row'><div class='col-xs-12 col-md-4 thumb-main'><div class='main-prod-img'>";
    html += "<div><img class='Catalog MainImage' src='" + product.MainImage + "' /></div>";

    html += "<div>" + product.description + "</div>";
    html += "<div>" + product.model + "</div>";
    html += "<div>" + product.price + "</div>";

    $.each(product.ProductImages, function (element, image) {
        html += "<div id='ImageContainer'>Images:<ul>";
        html += "<li><img class='Thumb' src='" + image.imgUrl + "' /></li></ul>";
    });

    html += "</div><div class='product-text'><p class='p-model'>";
    html += "Model: " + myProduct.model + "</p><p class='p-price'>Price: $" + myProduct.price;
    html += "</p></div></div><div class='col-xs-12 col-md-6'><div class='product-description'>";
    html += "<p style='text-align: justify;'>" + myProduct.description + "</p></div></div>";

    $("#prueba2").append(html);
}

function getJsonFromUrl() {
    var query = location.search.substr(1);
    var result = {};
    query.split("&").forEach(function (part) {
        var item = part.split("=");

        //Decode to avoid errors due to blank spaces on the URL
        result[item[0]] = decodeURIComponent(item[1]);
    });
    //we need only the ID
    return result['id '];
}