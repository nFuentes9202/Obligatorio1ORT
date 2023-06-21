//document.querySelector(".formDescuento").addEventListener("submit", validarDatos);
let elementosDescuento = document.getElementsByClassName('formDescuento');

// Itera a través de cada elemento y aplica el event listener
for (var i = 0; i < elementosDescuento.length; i++) {
    var elemento = elementosDescuento[i];
    elemento.addEventListener('submit', validarDatos);
}
function validarDatos(evt) {
    evt.preventDefault();
    
    let idSeleccionado = this.getAttribute("id");
    idSeleccionado = idSeleccionado.substring(2);
    let descuento = document.querySelector("#in" + idSeleccionado).value;
    if (descuento != "") {

        this.submit();
    } else {
        document.querySelector("#pDescuento").innerHTML = "Verifique los datos";
    }
}
