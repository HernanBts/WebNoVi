
//document.getElementById("accbut").addEventListener("click",openNav);
function openNav() {
    var e = document.getElementById("mySideAcc");
    if (e.style.width == '250px') {
        e.style.width = '0px';
    }
    else {
        e.style.width = '250px';
    }
}

//document.getElementById("closemySidenav").addEventListener("click",closeNav);
function setActiveAccesibility() {
    if (document.querySelector('#content').contains(document.querySelector('.highContrast'))) {
        document.querySelector('body').classList.add('w3-black');
    } else {
        document.querySelector('body').classList.remove('w3-black');
    }

    if (document.querySelector('#content').contains(document.querySelector('.fuentegrande'))) {
        document.getElementById("btnFuenteGrande").classList.add("active-accesibility");
        document.getElementById("btnFuenteNormal").classList.remove("active-accesibility");
    }
    else {
        document.getElementById("btnFuenteGrande").classList.remove("active-accesibility");
        document.getElementById("btnFuenteNormal").classList.add("active-accesibility");
    }
    if (document.querySelector('#content').contains(document.querySelector('.highContrast'))) {
        document.getElementById("btnHighContrast").classList.add("active-accesibility");
        document.getElementById("btnLowContrast").classList.remove("active-accesibility");
    }
    else {
        document.getElementById("btnHighContrast").classList.remove("active-accesibility");
        document.getElementById("btnLowContrast").classList.add("active-accesibility");
    }
    closeNav();
}

function closeNav() {
    document.getElementById("mySideAcc").style.width = "0";
}
function añadirFuenteGrande() {
    document.getElementById("content").classList.add("fuentegrande");
    setActiveAccesibility();
}
function añadirFuenteNormal() {
    document.getElementById("content").classList.remove("fuentegrande");
    setActiveAccesibility();
}
function highContrast() {
    document.getElementById("content").classList.add("highContrast");
    setActiveAccesibility();
}
function lowContrast() {
    document.getElementById("content").classList.remove("highContrast");
    setActiveAccesibility();
}

$(document).ready(function () {
    $("a.añadir").click(function () {
        $("p").addClass("test");
    });
    $("a.quitar").click(function () {
        $("p").removeClass("test");
    });
    $('.nav-button').click(function (event) {
        event.preventDefault();
        var hash = this.hash;
        $('html, body').animate({
            scrollTop: $(hash).offset().top
        }, 800, function () {

            window.location.hash = hash;
        });
    });


    //$(".buttonacctsidebar").click(function openNav() {
    //    document.getElementById("mySidenav").style.width = "250px";
    //});
    //$(".closebtn").click(function closeNav() {
    //    document.getElementById("mySidenav").style.width = "0px";
    //});

    //fuentes
    //$("#btnFuenteGrande").click(function fuenteGrande() {
    //    $(".contenido").addClass("big-font");
    //});
    //$("#btnFuenteNormal").click(function fuenteNormal() {
    //    $(".contenido").removeClass("big-font");
    //});
    //$("#btnHighContrast").click(function highContrast() {
    //    $(".contenido").addClass("body");
    //});
});
$(document).ready(function () {
    var textSpanish = "";
    $.get("https://query.yahooapis.com/v1/public/yql?q=select%20item.condition%20from%20weather.forecast%20where%20u=%27c%27%20and%20woeid%20%3D%20466870&format=json", function (response) {
        var state = response.query.results.channel.item.condition.code;
        if (state == "0") {
            textSpanish += "hay tornados.";
        }
        else if (state == "1") {
            textSpanish += "hay tormenta tropical.";
        }
        else if (state == "2") {
            textSpanish += "hay huracán.";
        }
        else if (state == "3") {
            textSpanish += "hay tormentas eléctricas severas.";
        }
        else if (state == "4") {
            textSpanish += "hay tormentas eléctricas.";
        }
        else if (state == "5") {
            textSpanish += "hay aguanieve.";
        }
        else if (state == "6") {
            textSpanish += "hay lluvia con aguanieve.";
        }
        else if (state == "7") {
            textSpanish += "hay nieve y aguanieve.";
        }
        else if (state == "8") {
            textSpanish += "hay llovizna helada.";
        }
        else if (state == "9") {
            textSpanish += "está lloviznando.";
        }
        else if (state == "10") {
            textSpanish += "hay lluvia helada.";
        }
        else if (state == "11") {
            textSpanish += "hay chubascos.";
        }
        else if (state == "12") {
            textSpanish += "hay chubascos.";
        }
        else if (state == "13") {
            textSpanish += "hay ráfagas de nieve.";
        }
        else if (state == "14") {
            textSpanish += "hay leves chubascos de nieve.";
        }
        else if (state == "15") {
            textSpanish += "hay ventisca de nieve.";
        }
        else if (state == "16") {
            textSpanish += "está nevando.";
        }
        else if (state == "17") {
            textSpanish += "está granizando.";
        }
        else if (state == "18") {
            textSpanish += "hay aguanieve.";
        }
        else if (state == "19") {
            textSpanish += "hay polvo.";
        }
        else if (state == "20") {
            textSpanish += "hay neblina.";
        }
        else if (state == "21") {
            textSpanish += "hay neblina densa.";
        }
        else if (state == "22") {
            textSpanish += "hay humo.";
        }
        else if (state == "23") {
            textSpanish += "hay chaparrones.";
        }
        else if (state == "24") {
            textSpanish += "hay vientos moderados.";
        }
        else if (state == "25") {
            textSpanish += "está helando.";
        }
        else if (state == "26") {
            textSpanish += "está nublado.";
        }
        else if (state == "27") {
            textSpanish += "es de noche y está mayormente nublado.";
        }
        else if (state == "28") {
            textSpanish += "es de dia y está mayormente nublado.";
        }
        else if (state == "29") {
            textSpanish += "es de noche y está parcialmente nublado.";
        }
        else if (state == "30") {
            textSpanish += "es de día y está parcialmente nublado.";
        }
        else if (state == "31") {
            textSpanish += "es de noche y está despejado.";
        }
        else if (state == "32") {
            textSpanish += "está soleado.";
        }
        else if (state == "33") {
            textSpanish += "es de noche y está despejado.";
        }
        else if (state == "34") {
            textSpanish += "es de dia y está despejado.";
        }
        else if (state == "35") {
            textSpanish += "está lloviendo con granizo.";
        }
        else if (state == "36") {
            textSpanish += "hace mucho calor.";
        }
        else if (state == "37") {
            textSpanish += "hay tormentas eléctricas aisladas.";
        }
        else if (state == "38") {
            textSpanish += "hay tormentas eléctricas dispersas.";
        }
        else if (state == "39") {
            textSpanish += "hay tormentas eléctricas dispersas.";
        }
        else if (state == "40") {
            textSpanish += "hay chubascos dispersos.";
        }
        else if (state == "41") {
            textSpanish += "está nevando mucho.";
        }
        else if (state == "42") {
            textSpanish += "hay chubascos de nieve dispersos.";
        }
        else if (state == "43") {
            textSpanish += "está nevando mucho.";
        }
        else if (state == "44") {
            textSpanish += "está parcialmente nublado.";
        }
        else if (state == "45") {
            textSpanish += "hay truenos.";
        }
        else if (state == "46") {
            textSpanish += "hay chubascos de nieve.";
        }
        else if (state == "47") {
            textSpanish += "hay chubascos aislados.";
        }
        else {
            textSpanish += "no tenemos información disponible.";
        }
        $("#climasimple").text("La temperatura actual en Resistencia es de: " + response.query.results.channel.item.condition.temp + "°C, " + textSpanish.toString());
    });

});
