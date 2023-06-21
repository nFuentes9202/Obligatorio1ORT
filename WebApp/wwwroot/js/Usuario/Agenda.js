
document.querySelector("#formFecha").addEventListener("submit", validarDatosFecha);

function validarDatosFecha(evt) {
    evt.preventDefault();
    let fecha = document.querySelector("#strFecha").value;
    if (fecha != "") {
        this.submit();
    } else {
        document.querySelector("#pFecha").innerHTML = "Verifique los datos";
    }
}

document.querySelector("#formDocumento").addEventListener("submit", validarDatosDocumento);

function validarDatosDocumento(evt) {
    evt.preventDefault();
    let documento = document.querySelector("#strNumero").value;
    if (documento != "") {
        this.submit();
    } else {
        document.querySelector("#pDocumento").innerHTML = "Verifique los datos";
    }
}