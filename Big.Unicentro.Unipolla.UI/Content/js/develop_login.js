$("#btnEnviar").submit(function (e) {
    return false;
});

$("#btnEnviar").click(function (event) {
    event.preventDefault();
    var documento = $("#txtDocument").val();
    var codigo = $("#txtCode").val();

    if (!ValidateFormLogin()) {

        alert(" debes completar el formulario para poder continuar.");

    } else {
        $.ajax({
                type: 'POST',
                url: pathSite + "Account/Login",
                ContentType: 'application/json; charset=utf-8',
                data: {
                    'document': documento,
                    'code': codigo
                },
                beforeSend: function() { $("#spinner").fadeIn("slow"); },
                error: function(data) {
                    $("#spinner").fadeOut("slow");
                    alert("Ocurrio un error por favor intentelo de nuevo " + data, "");
                },
            })
            .done(function(data) {
                if (data.Result === false) {
                    $("#spinner").fadeOut("slow"); 
                    alert(data.Message.Message);
                } else {
                    window.location = pathSite + "Home/Index";
                }
            });

    }
});


function ValidateFormLogin() {

    var isValid = true;

    var documento = $("#txtDocument").val();
    var codigo = $("#txtCode").val();

    if (documento === "") {

        isValid = false;
    }

    if (codigo === "") {

        isValid = false;
    }

    return isValid;
}