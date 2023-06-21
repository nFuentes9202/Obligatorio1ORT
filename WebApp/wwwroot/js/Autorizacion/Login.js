
document.querySelector("#formLogin").addEventListener("submit", validarDatos);

function validarDatos(evt) {
    evt.preventDefault();
    let email = document.querySelector("#floatingInput").value;
    let contra = document.querySelector("#floatingPassword").value;
    if (email != "" && contra != "") {
        this.submit();
    } else {
        document.querySelector("#pLogin").innerHTML = "Verifique los datos";
    }
}