var langs = ['en', 'it', 'es'];
var langCode = '';
var langJS = null;


var translate = function (jsdata) {
  $("[tkey]").each(function (index) {
    var strTr = jsdata[$(this).attr('tkey')];
    $(this).html(strTr);
  });
}


$(document).ready(function () {


  $('#form-contact').submit(function (event) {
    event.preventDefault();
    var contentform = $(this).serialize();
    $.ajax({
      url: url + 'contacto.php',
      type: 'POST',
      data: contentform,
      success: function (result) {
        $('.textalert').text(result.resultado);
        $('.alerta').show();
        setTimeout(function(){       
          window.location.assign(url);
        },3000);
      }
    });
    return false;
  });
  
  $('.cerraralerta').click(function(){
    $('.alerta').hide();
  });

  $('.historia .infobottom').scrollToFixed();
  $('.historia .triangle_r').scrollToFixed();
  $('.historia .triangle_l').scrollToFixed();

  langCode = navigator.language.substr(0, 2);

  if ((localStorage.lang != undefined) && (localStorage.lang == "en")) {
    $.getJSON('resources/lang/en.json', translate);
    $('.cambiaidioma').html('English <img src="resources/assets/images/en.png">');
  } else if ((localStorage.lang != undefined) && (localStorage.lang == "pr")) {
    $.getJSON('resources/lang/pr.json', translate);
    $('.cambiaidioma').html('portuguese <img src="resources/assets/images/pr.png">');
  } else if ((localStorage.lang != undefined) && (localStorage.lang == "it")) {
    $.getJSON('resources/lang/it.json', translate);
    $('.cambiaidioma').html('Italy <img src="resources/assets/images/it.png">');
  } else {
    //console.log('no esta');
  }

  $('.langen').click(function () {
    localStorage.clear();
    localStorage.setItem('lang', 'en');
    location.reload();
  });

  $('.langpr').click(function () {
    localStorage.clear();
    localStorage.setItem('lang', 'pr');
    location.reload();
  });

  $('.langit').click(function () {
    localStorage.clear();
    localStorage.setItem('lang', 'it');
    location.reload();
  });

  $('.langes').click(function () {
    localStorage.clear();
    location.reload();
  });

  /*if (langCode in langs) {
    $.getJSON('resources/lang/' + langCode + '.json', translate);
  } else {
    $.getJSON('resources/lang/en.json', translate);
  }*/

  $('.atunbtn').click(function () {
    $('.prodslata, .titleprod').hide();
    $('.prodsatun').show();
    $('.titleatun').show();
  });

  $('.envasesbtn').click(function () {
    $('.prodsatun, .titleprod').hide();
    $('.prodslata').show();
    $('.titleenvases').show();
  });

  $('.menumo').click(function () {
    $('header nav ul').toggle();
    $('.idioma ul').hide();
  });

  $('.cambiaidioma').click(function () {
    $('.idioma ul').toggle();
    $('header nav ul').hide();
  });

  $('#contacto').submit(function (event) {
    var nombres;
    var apellidos;
    var celular;
    var email;
    var mensajes;

    nombres = $('#nombres').val();
    apellidos = $('#apellidos').val();
    celular = $('#celular').val();
    email = $('#email').val();
    mensajes = $('#mensaje').val();

    $.post("contacto.php", {
      nombres: nombres,
      apellidos: apellidos,
      celular: celular,
      email: email,
      mensajes: mensajes
    }, function (data) {
      alert('El mensaje fue enviado');
    }, "json");
    return false;

  });
});