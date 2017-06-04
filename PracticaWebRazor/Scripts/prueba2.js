$(document).ready(
function(){
	var miParrafo = $("#mi-parrafo");
	miParrafo.click(clickEnParrafo);
	
	var otroParrafo = $("#mi-parrafo-2");
	otroParrafo.click
})


/*no puedo mandar la variable ejecucion al $(document).ready() porque estoy 
guardando el resultado de la ejecucion del metodo click de jQuery*/

var ejecucion = $("#mi-parrafo").click(function(){ //listener de un click en el parrafo
	$("#resultado").text("click en mi-parrafo!") //sobre el elemento #resultado 
})

function clickEnParrafo(){ //listener de un click en el parrafo
	$("#resultado").text("click en mi-parrafo!") //sobre el elemento #resultado 
}

//#############################################

function requestAlServidor(){
	$.ajax({
		
	})
}

