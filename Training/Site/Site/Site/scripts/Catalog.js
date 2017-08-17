//Create a JSON Object that contains my products information.

//Ready: After HTML loads
$(document).ready(function () {
    $("#DynamicHTML").append(buildMyProduct(JSONCatalog));

    GetAllProducts();


});


//Dynamic build your collection
function buildMyProduct(obj) {
    var html = "";
    $.each(obj, function (element, object) {
        html += "<div><a href='details.html?id = " + object.id + "'>" + object.title + "</a></div>"
        //html += "<div><img class='Catalog' src='" + object.imgUrl + "' /></div>";
        html += "<div><img src='" + object.imgUrl + "' /></div>";
        html += "<div>" + object.description + "</div>";
        html += "<div>" + object.model + "</div>";
        html += "<div>" + object.price + "</div>";
    });
    return html;
}

function GetAllProducts() {
    $.ajax({
        type: 'GET',
        url: 'http://localhost:3795/api/product',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

        },
        error: function (a, b, c) {

        }
    });
}