function myfuncion(){
    let Nombre = document.getElementById("txt_nombre").value;
    var Apellido = document.getElementById("txt_apellido").value;
    var Email = document.getElementById("txt_email").value;
    var ConfirmarEmail = document.getElementById("txt_confirmaremail").value;
    var Usuario = document.getElementById("txt_usuario").value;
    var Contraseña = document.getElementById("txt_contraseña").value;
    var ConfirmarContraseña = document.getElementById("txt_confirmarcontraseña").value;

    if(Nombre != ""){
        alert("Nombre: "+ Nombre+ "\nApellido: "+ Apellido+ "\nEmail: "+ Email+ "\nConfirmar Email: "+ 
        ConfirmarEmail+ "\nUsuario: "+ Usuario+ "\nContraseña: "+ Contraseña+ "\nConfirmarContraseña: "+ ConfirmarContraseña);
    }else{
        alert('El campo no puede estar vacio')
    }    
 

}