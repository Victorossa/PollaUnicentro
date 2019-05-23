var pathSite = "";

function GetPathSite() {
    return this.pathSite;
};

function SetPathSite(pathSite) {
    this.pathSite = pathSite;
};

var pathLocalhost = window.location.protocol + "//" + window.location.hostname + "/";
pathSite = (pathLocalhost === "http://localhost/") ? "http://localhost:8771/" : pathSite;
pathSite = (pathLocalhost === "http://test.multistrategy.co/") ? "http://test.multistrategy.co/UniPolla/" : pathSite;
pathSite = (pathLocalhost === "https://www.unicentromedellin.com.co/") ? "https://www.unicentromedellin.com.co/unipolla/" : pathSite;


$(".score").attr('disabled', 'disabled');

$("#ddl1A").change(function () {
    $('#ddlW49 option').remove();
    var data1 = $("#ddl1A option:selected");
    var data2 = $("#ddl2B option:selected");
    $("#ddlW49").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});
$("#ddl2B").change(function () {
    $('#ddlW49 option').remove();
    var data1 = $("#ddl1A option:selected");
    var data2 = $("#ddl2B option:selected");
    $("#ddlW49").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});

$("#ddl1C").change(function () {
    $('#ddlW51 option').remove();
    var data1 = $("#ddl1C option:selected");
    var data2 = $("#ddl2D option:selected");
    $("#ddlW51").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');


});
$("#ddl2D").change(function () {
    $('#ddlW51 option').remove();
    var data1 = $("#ddl1C option:selected");
    var data2 = $("#ddl2D option:selected");
    $("#ddlW51").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');


});

$("#ddl1B").change(function () {
    $('#ddlW50 option').remove();
    var data1 = $("#ddl1B option:selected");
    var data2 = $("#ddl2A option:selected");
    $("#ddlW50").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});
$("#ddl2A").change(function () {
    $('#ddlW50 option').remove();
    var data1 = $("#ddl1B option:selected");
    var data2 = $("#ddl2A option:selected");
    $("#ddlW50").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});

$("#ddl1D").change(function () {
    $('#ddlW52 option').remove();
    var data1 = $("#ddl1D option:selected");
    var data2 = $("#ddl2C option:selected");
    $("#ddlW52").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});
$("#ddl2C").change(function () {
    $('#ddlW52 option').remove();
    var data1 = $("#ddl1D option:selected");
    var data2 = $("#ddl2C option:selected");
    $("#ddlW52").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});

//$("#ddl1E").change(function () {
//    $('#ddl1E-2F option').remove();
//    var data1 = $("#ddl1E option:selected");
//    var data2 = $("#ddl2F option:selected");
//    $("#ddl1E-2F").append('<option value="-1">-- Seleccione --</option>')
//        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
//        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
//});
//$("#ddl2F").change(function () {
//    $('#ddl1E-2F option').remove();
//    var data1 = $("#ddl1E option:selected");
//    var data2 = $("#ddl2F option:selected");
//    $("#ddl1E-2F").append('<option value="-1">-- Seleccione --</option>')
//        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
//        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
//});

//$("#ddl1G").change(function () {
//    $('#ddl1G-2H option').remove();
//    var data1 = $("#ddl1G option:selected");
//    var data2 = $("#ddl2H option:selected");
//    $("#ddl1G-2H").append('<option value="-1">-- Seleccione --</option>')
//        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
//        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
//});
//$("#ddl2H").change(function () {
//    $('#ddl1G-2H option').remove();
//    var data1 = $("#ddl1G option:selected");
//    var data2 = $("#ddl2H option:selected");
//    $("#ddl1G-2H").append('<option value="-1">-- Seleccione --</option>')
//        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
//        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
//});

//$("#ddl1F").change(function () {
//    $('#ddl1F-2E option').remove();
//    var data1 = $("#ddl1F option:selected");
//    var data2 = $("#ddl2E option:selected");
//    $("#ddl1F-2E").append('<option value="-1">-- Seleccione --</option>')
//        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
//        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
//});
//$("#ddl2E").change(function () {
//    $('#ddl1F-2E option').remove();
//    var data1 = $("#ddl1F option:selected");
//    var data2 = $("#ddl2E option:selected");
//    $("#ddl1F-2E").append('<option value="-1">-- Seleccione --</option>')
//        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
//        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
//});


//$("#ddl1H").change(function () {
//    $('#ddl1H-2G option').remove();
//    var data1 = $("#ddl1H option:selected");
//    var data2 = $("#ddl2G option:selected");
//    $("#ddl1H-2G").append('<option value="-1">-- Seleccione --</option>')
//        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
//        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
//});
//$("#ddl2G").change(function () {
//    $('#ddl1H-2G option').remove();
//    var data1 = $("#ddl1H option:selected");
//    var data2 = $("#ddl2G option:selected");
//    $("#ddl1H-2G").append('<option value="-1">-- Seleccione --</option>')
//        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
//        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
//});

//cuartos
//$("#ddl1C-2D").change(function () {
//    $('#ddlW49 option').remove();
//    var data1 = $("#ddl1C-2D option:selected");
//    var data2 = $("#ddl1A-2B option:selected");
//    $("#ddlW49").append('<option value="-1">-- Seleccione --</option>')
//        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
//        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
//});
//$("#ddl1A-2B").change(function () {
//    $('#ddlW49 option').remove();
//    var data1 = $("#ddl1C-2D option:selected");
//    var data2 = $("#ddl1A-2B option:selected");
//    $("#ddlW49").append('<option value="-1">-- Seleccione --</option>')
//        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
//        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
//});

//$("#ddl1B-2A").change(function () {
//    $('#ddlW50 option').remove();
//    var data1 = $("#ddl1B-2A option:selected");
//    var data2 = $("#ddl1D-2C option:selected");
//    $("#ddlW50").append('<option value="-1">-- Seleccione --</option>')
//        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
//        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
//});
//$("#ddl1D-2C").change(function () {
//    $('#ddlW50 option').remove();
//    var data1 = $("#ddl1B-2A option:selected");
//    var data2 = $("#ddl1D-2C option:selected");
//    $("#ddlW50").append('<option value="-1">-- Seleccione --</option>')
//        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
//        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
//});

//$("#ddl1E-2F").change(function () {
//    $('#ddlW51 option').remove();
//    var data1 = $("#ddl1E-2F option:selected");
//    var data2 = $("#ddl1G-2H option:selected");
//    $("#ddlW51").append('<option value="-1">-- Seleccione --</option>')
//        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
//        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
//});
//$("#ddl1G-2H").change(function () {
//    $('#ddlW51 option').remove();
//    var data1 = $("#ddl1E-2F option:selected");
//    var data2 = $("#ddl1G-2H option:selected");
//    $("#ddlW51").append('<option value="-1">-- Seleccione --</option>')
//        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
//        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
//});

//$("#ddl1F-2E").change(function () {
//    $('#ddlW52 option').remove();
//    var data1 = $("#ddl1F-2E option:selected");
//    var data2 = $("#ddl1H-2G option:selected");
//    $("#ddlW52").append('<option value="-1">-- Seleccione --</option>')
//        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
//        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
//});
//$("#ddl1H-2G").change(function () {
//    $('#ddlW52 option').remove();
//    var data1 = $("#ddl1F-2E option:selected");
//    var data2 = $("#ddl1H-2G option:selected");
//    $("#ddlW52").append('<option value="-1">-- Seleccione --</option>')
//        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
//        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
//});

//semifinal
$("#ddlW49").change(function () {
    $('#ddlW61 option').remove();
    var data1 = $("#ddlW49 option:selected");
    var data2 = $("#ddlW51 option:selected");
    $("#ddlW61").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});
$("#ddlW51").change(function () {
    $('#ddlW61 option').remove();
    var data1 = $("#ddlW49 option:selected");
    var data2 = $("#ddlW51 option:selected");
    $("#ddlW61").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});


//final
$("#ddlW50").change(function () {
    $('#ddlW62 option').remove();
    var data1 = $("#ddlW50 option:selected");
    var data2 = $("#ddlW52 option:selected");
    $("#ddlW62").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});
$("#ddlW52").change(function () {
    $('#ddlW62 option').remove();
    var data1 = $("#ddlW50 option:selected");
    var data2 = $("#ddlW52 option:selected");
    $("#ddlW62").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});

//ganador
$("#ddlW61").change(function () {
    $('#ddlWin option').remove();
    var data1 = $("#ddlW61 option:selected");
    var data2 = $("#ddlW62 option:selected");
    $("#ddlWin").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});
$("#ddlW62").change(function () {
    $('#ddlWin option').remove();
    var data1 = $("#ddlW61 option:selected");
    var data2 = $("#ddlW62 option:selected");
    $("#ddlWin").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});


//tercero
$("#ddlW49").change(function () {
    $('#ddlL61 option').remove();
    var data1 = $("#ddlW49 option:selected");
    var data2 = $("#ddlW51 option:selected");
    $("#ddlL61").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});
$("#ddlW51").change(function () {
    $('#ddlL61 option').remove();
    var data1 = $("#ddlW49 option:selected");
    var data2 = $("#ddlW51 option:selected");
    $("#ddlL61").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});

$("#ddlW50").change(function () {
    $('#ddlL62 option').remove();
    var data1 = $("#ddlW50 option:selected");
    var data2 = $("#ddlW52 option:selected");
    $("#ddlL62").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});
$("#ddlW52").change(function () {
    $('#ddlL62 option').remove();
    var data1 = $("#ddlW50 option:selected");
    var data2 = $("#ddlW52 option:selected");
    $("#ddlL62").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});

//ganador tercero

$("#ddlL61").change(function () {
    $('#ddltercero option').remove();
    var data1 = $("#ddlL61 option:selected");
    var data2 = $("#ddlL62 option:selected");
    $("#ddltercero").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});
$("#ddlL62").change(function () {
    $('#ddltercero option').remove();
    var data1 = $("#ddlL61 option:selected");
    var data2 = $("#ddlL62 option:selected");
    $("#ddltercero").append('<option value="-1">-- Seleccione --</option>')
        .append('<option value="' + data1.val() + '">' + data1.text() + '</option>')
        .append('<option value="' + data2.val() + '">' + data2.text() + '</option>');
});


$("#btnGuardar").click(function (event) {

    event.preventDefault();
    var listBets = GetData();

    if (!ValidateFormBet()) {

        alert("debes completar el formulario para poder continuar.");

    } else {
        $.ajax({
            type: 'POST',
            url: pathSite + "Home/SaveBet",
            ContentType: 'application/json; charset=utf-8',
            data: { listBets: listBets },
            beforeSend: function () { $("#spinner").fadeIn("slow"); },
            error: function (data) {
                $("#spinner").fadeOut("slow");
                alert('Se presentó un error, intentelo nuevamente.');
            },
        })
            .done(function (data) {
                $("#spinner").fadeOut("slow");
                if (data.Result === false) {
                    $("#spinner").fadeOut("slow");
                    alert(data.Message.Message);
                } else {
                    alert(data.Message.Message);
                    window.location = pathSite + "Home/Index";
                }
            });

    }
});

function ValidateFormBet() {

    var isValid = true;

    var ddl1C = $("#ddl1C  option:selected").val();
    var ddl2D = $("#ddl2D  option:selected").val();
    var ddl1A = $("#ddl1A option:selected").val();
    var ddl2B = $("#ddl2B option:selected").val();
    var ddl1B = $("#ddl1B  option:selected").val();
    var ddl2A = $("#ddl2A  option:selected").val();
    var ddl1D = $("#ddl1D  option:selected").val();
    var ddl2C = $("#ddl2C  option:selected").val();


    //var ddl1E = $("#ddl1E  option:selected").val();
    //var ddl2F = $("#ddl2F  option:selected").val();
    //var ddl1G = $("#ddl1G  option:selected").val();
    //var ddl2H = $("#ddl2H  option:selected").val();
    //var ddl1F = $("#ddl1F  option:selected").val();
    //var ddl2E = $("#ddl2E  option:selected").val();
    //var ddl1H = $("#ddl1H  option:selected").val();
    //var ddl2G = $("#ddl2G  option:selected").val();
    //var ddlW49 = $("#ddl1A-2B  option:selected").val();
    //var ddlW50 = $("#ddl1C-2D  option:selected").val();
    //var ddlW53 = $("#ddl1E-2F  option:selected").val();
    //var ddlW54 = $("#ddl1G-2H  option:selected").val();
    //var ddlW55 = $("#ddl1F-2E  option:selected").val();
    //var ddlW56 = $("#ddl1H-2G  option:selected").val();
    //var ddlW51 = $("#ddl1B-2A  option:selected").val();
    //var ddlW52 = $("#ddl1D-2C  option:selected").val();


    var ddlW57 = $("#ddlW49  option:selected").val();
    var ddlW58 = $("#ddlW50  option:selected").val();
    var ddlW59 = $("#ddlW51  option:selected").val();
    var ddlW60 = $("#ddlW52  option:selected").val();
    var ddlL61 = $("#ddlL61  option:selected").val();
    var ddlL62 = $("#ddlL62  option:selected").val();
    var ddlW61 = $("#ddlW61  option:selected").val();
    var ddlW62 = $("#ddlW62  option:selected").val();
    var ddlWin = $("#ddlWin  option:selected").val();
    var ddltercero = $("#ddltercero  option:selected").val();

    if (ddl1C === "-1" || ddl2D === "-1" || ddl1A === "-1" || ddl2B === "-1"
        || ddl1B === "-1" || ddl2A === "-1" || ddl1D === "-1" || ddl2C === "-1"


        //|| ddl1E === "-1" || ddl2F === "-1" || ddl1G === "-1" || ddl2H === "-1"
        //|| ddl1F === "-1" || ddl2E === "-1" || ddl1H === "-1" || ddl2G === "-1"
        //|| ddlW49 === "-1" || ddlW50 === "-1" || ddlW53 === "-1" || ddlW54 === "-1"
        //|| ddlW55 === "-1" || ddlW56 === "-1" || ddlW51 === "-1" || ddlW52 === "-1"

        || ddlW57 === "-1" || ddlW58 === "-1" || ddlW59 === "-1" || ddlW60 === "-1"
        || ddlL61 === "-1" || ddlL62 === "-1" || ddlW61 === "-1" || ddlW62 === "-1"
        || ddlWin === "-1" || ddltercero === "-1") {

        isValid = false;
    }


    return isValid;
}

function GetData() {

    var ddl1C = $("#ddl1C  option:selected").val();
    var ddl2D = $("#ddl2D  option:selected").val();
    var ddl1A = $("#ddl1A option:selected").val();
    var ddl2B = $("#ddl2B option:selected").val();
    var ddl1B = $("#ddl1B  option:selected").val();
    var ddl2A = $("#ddl2A  option:selected").val();
    var ddl1D = $("#ddl1D  option:selected").val();
    var ddl2C = $("#ddl2C  option:selected").val();
    //var ddl1E = $("#ddl1E  option:selected").val();
    //var ddl2F = $("#ddl2F  option:selected").val();
    //var ddl1G = $("#ddl1G  option:selected").val();
    //var ddl2H = $("#ddl2H  option:selected").val();
    //var ddl1F = $("#ddl1F  option:selected").val();
    //var ddl2E = $("#ddl2E  option:selected").val();
    //var ddl1H = $("#ddl1H  option:selected").val();
    //var ddl2G = $("#ddl2G  option:selected").val();
    //var ddlW49 = $("#ddl1A-2B  option:selected").val();
    //var ddlW50 = $("#ddl1C-2D  option:selected").val();
    //var ddlW53 = $("#ddl1E-2F  option:selected").val();
    //var ddlW54 = $("#ddl1G-2H  option:selected").val();
    //var ddlW55 = $("#ddl1F-2E  option:selected").val();
    //var ddlW56 = $("#ddl1H-2G  option:selected").val();
    //var ddlW51 = $("#ddl1B-2A  option:selected").val();
    //var ddlW52 = $("#ddl1D-2C  option:selected").val();
    var ddlW57 = $("#ddlW49  option:selected").val();
    var ddlW58 = $("#ddlW51  option:selected").val();
    var ddlW59 = $("#ddlW50  option:selected").val();
    var ddlW60 = $("#ddlW52  option:selected").val();
    var ddlL61 = $("#ddlL61  option:selected").val();
    var ddlL62 = $("#ddlL62  option:selected").val();
    var ddlW61 = $("#ddlW61  option:selected").val();
    var ddlW62 = $("#ddlW62  option:selected").val();
    var ddlWin = $("#ddlWin  option:selected").val();
    var ddltercero = $("#ddltercero  option:selected").val();

    var markers;
    return markers = [
        { IdMatch: 19, IdTeam1: ddl1A, IdTeam2: ddl2B },
        { IdMatch: 20, IdTeam1: ddl1C, IdTeam2: ddl2D },
        //{ IdMatch: 3, IdTeam1: ddl1E, IdTeam2: ddl2F },
        //{ IdMatch: 4, IdTeam1: ddl1G, IdTeam2: ddl2H },
        { IdMatch: 21, IdTeam1: ddl1B, IdTeam2: ddl2A },
        { IdMatch: 22, IdTeam1: ddl1D, IdTeam2: ddl2C },
        //{ IdMatch: 7, IdTeam1: ddl1F, IdTeam2: ddl2E },
        //{ IdMatch: 8, IdTeam1: ddl1H, IdTeam2: ddl2G },
        //{ IdMatch: 9, IdTeam1: ddlW49, IdTeam2: ddlW50 },
        //{ IdMatch: 10, IdTeam1: ddlW53, IdTeam2: ddlW54 },
        //{ IdMatch: 11, IdTeam1: ddlW51, IdTeam2: ddlW52 },
        //{ IdMatch: 12, IdTeam1: ddlW55, IdTeam2: ddlW56 },
        { IdMatch: 23, IdTeam1: ddlW57, IdTeam2: ddlW58 },
        { IdMatch: 24, IdTeam1: ddlW59, IdTeam2: ddlW60 },
        { IdMatch: 25, IdTeam1: ddlL61, IdTeam2: ddlL62 },
        { IdMatch: 26, IdTeam1: ddlW61, IdTeam2: ddlW62 },
        { IdMatch: 27, IdTeam1: ddltercero, IdTeam2: ddltercero },
        { IdMatch: 28, IdTeam1: ddlWin, IdTeam2: ddlWin }
    ];
}