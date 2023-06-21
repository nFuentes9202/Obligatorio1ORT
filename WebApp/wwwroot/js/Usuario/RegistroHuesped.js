
document.querySelector("#formRegistro").addEventListener("submit", validarDatos);

function validarDatos(evt) {
    evt.preventDefault();
    let nombre = document.querySelector("#Nombre").value;
    let apellido = document.querySelector("#Apellido").value;
    let email = document.querySelector("#Email").value;
    let contra = document.querySelector("#Contrasenia").value;
    let nroDocumento = document.querySelector("#NumeroDocumento").value;
    let habitacion = document.querySelector("#nroHabitacion").value;
    if (nombre != "" && apellido != "" && email != "" && contra != "" && nroDocumento != "" && habitacion != "") {
        this.submit();
    } else {
        document.querySelector("#pRegistro").innerHTML = "Verifique los datos";
    }
}