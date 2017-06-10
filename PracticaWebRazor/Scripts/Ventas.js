$(document).ready(
    function () {
        Venta.setupAutoComplete();
    }
)

// creo variable venta para prevenir q se repita el nombre de metodo setup en otro archivo de js
// todos las function son globales al browser

var Venta = function () { 
    
}

Venta.setupAutoComplete = function () {
    $.ajax({
        url: "/Producto/ObtenerNombreProductos",
        success: function (data) {
            $("#txt-Producto").AutoComplete({
                source: data,
                focus: function (asd, i) { //establece cual atributo del json se usa para mostrar durante el autocompletado
                    $("#txt-Producto").val(i.item.Name);
                }
            });
        }
    })
}