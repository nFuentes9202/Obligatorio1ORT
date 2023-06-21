document.querySelector("#formIndex").addEventListener("submit", validarDatos);

function validarDatos(evt) {
    evt.preventDefault();
    let fecha = document.querySelector("#strFecha").value;
    if (fecha != "") {
        this.submit();
    } else {
        document.querySelector("#pLogin").innerHTML = "Verifique los datos";
    }
}