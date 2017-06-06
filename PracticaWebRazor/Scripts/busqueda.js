$(document).ready(
function () {
    $("#btn-buscar").click(obtenerVista)
});

function exito(data) { //data es la respuesta del servidor (JSON en este caso)
    //$(document).html(data)
    //aca iria funcion que agarra un JSON y parsea:
    //JSON.parse(data) //???
    var clientesEncontrados = Json.parse(data);
    var tabla = $("#tabla")

    for (var i = 0; i < clientesEncontrados.length; i++) {
        var tr = "<tr><td>" + clientesEncontrados[i].Apellido + "<tr><td>" + clientesEncontrados[i].Nombre
        tabla.find("tbody").append(tr);
    }
}

function obtenerVista() {
    $.ajax({//le paso un object js al metodo .ajax
        url: "/Cliente/BusquedaJSON",
        data: { cliente: $("#cliente-2").val() }, //guarda la cadena del campo de texto en 'cliente'
        dataType: 'json',
        type: "POST",
        success: exito,
    })
}