document.querySelector("#formIndex").addEventListener("submit", validarDatos);

function validarDatos(evt) {
    evt.preventDefault();
    let fecha = document.querySelector("#strFecha").value;
    if (fecha != "") {
        this.submit();
    } else {
        document.querySelector("#pBusqueda").innerHTML = "Verifique los datos";
    }
}