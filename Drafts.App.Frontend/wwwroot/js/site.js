function validacampos() {
  var user = document.frmLogin.txtusuario.value;
  if (user === "") {
    alert("Por favor, diigte el campo de usuario");
    document.frmLogin.txtusuario.focus();
    return false;
  }
  if (user.length > 10) {
    alert("El usuario es inválido");
    document.frmLogin.txtusuario.focus();
    return false;
  }

  var pwd = document.frmLogin.txtpass.value;
  var exp = /[\W_]/;

  if (pwd === "") {
    alert("Por favor, digite la contraseña");
    document.frmLogin.txtpass.focus();
    return false;
  } else if (pwd.length > 12) {
    alert("La contraseña debe ser de 3 caracteres");
    document.frmLogin.txtpass.focus();
    return false;
  } else if (exp.test(pwd)) {
    alert("La contraseña contiene caracteres ilegales");
    document.frmLogin.txtpass.focus();
    return false;
  } else {
    alert("Bienvenido al sistema");
    return true;
  }
}
