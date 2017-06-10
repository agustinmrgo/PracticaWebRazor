$(document).ready(
    $("#btn-buscar").click(function() { obtenerVista() })
);
//data es la respuesta del servidor (JSON en este caso)
//$(document).html(data)
function exito(data) {
    var table = '<table id=\"tabla\" class=\"table-bordered\"><thead><tr><th>Apellido</th><th>Nombre</th></tr></thead><tbody></tbody></table>'
    $('#tablaBuscar').append(table);
    
    $.each(data, function (i, cliente) { //para que sirve "i" index ???
        var bodyTabla = $("#tabla tbody");
        var tr = "<tr><td>" + cliente.Apellido + "</td><td>" + cliente.Nombre + "</td></tr>";
        bodyTabla.append(tr);
    })
}

function obtenerVista() {
    $.ajax({ //le paso un object js al metodo .ajax
        url: "/Cliente/BusquedaJSON",
        data: { cliente: $("#cliente-2").val() }, //guarda la cadena del campo de texto en 'cliente-2'
        dataType: 'json', //poner para que parsee el JSON!
        type: "POST",
        success: function (data) { exito(data) }
    })
}