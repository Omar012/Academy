//Create a JSON Object that contains my products information.

//Ready: After HTML loads
$(document).ready(function () {
    GetAllProducts();
    //$("#DynamicHTML").append(buildMyProduct(JSONCatalog));

});


//Dynamic build your collection
//function buildMyProduct(obj) {
//    var html = "";
//    $.each(obj, function (element, object) {
//        html += "<div><a href='details.html?id = " + object.id + "'>" + object.title + "</a></div>"
//        //html += "<div><img class='Catalog' src='" + object.imgUrl + "' /></div>";
//        html += "<div><img src='" + object.imgUrl + "' /></div>";
//        html += "<div>" + object.description + "</div>";
//        html += "<div>" + object.model + "</div>";
//        html += "<div>" + object.price + "</div>";
//    });
//    return html;
//}

function GetAllProducts() {
    $.ajax({
        type: 'GET',
        url: 'http://localhost:50275/api/product',
        contentType: "application/json; charset=utf-8",

        success: function (data) {
            var html = "";
            //Data es mi Catalogo en formato json, y object es cada elemento de éste
            $.each(data, function (element, object) {
      
                html += "<div class='col-xs-12 col-md-4'><div class='product-img'><img class='catalog-image' src='";
                html += object.ImageUrl + "'></div><div class='product-desc'><p class='prod-desc-title'>";
                html += "<a href='Detail.html?id=" + object.Id + "'>";
                html += object.Name + "</a></p><p class='prod-desc-text'>";
                html += object.ProductDescription + "</p></div></div></div>";
            });
            $("#prueba").append(html);
        },
        error: function (a, b, c) {

        }
   });
}