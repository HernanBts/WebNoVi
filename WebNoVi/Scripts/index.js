$(function () {
    $('#btnAddQuery').on("click", function () {
        var queryName = $('#queryTxtName').val();
        if (queryName == "") {
            $('#queryLblMessage').html('Debe ingresar un nombre...');
            return false;
        }
        var queryMail = $('#queryTxtMail').val();
        if (queryMail == "") {
            $('#queryLblMessage').html('Debe ingresar un E-Mail...');
            return false;
        }
        var querySubject = $('#queryTxtSubject').val();
        if (querySubject == "") {
            $('#queryLblMessage').html('Debe ingresar un asunto...');
            return false;
        }
        var queryMessage = $('#queryTxtMessage').val();
        if (queryMessage == "") {
            $('#queryLblMessage').html('Debe ingresar un mensaje...');
            return false;
        }

        var query = new Object();
        query.Date = "2000-01-01T00:00:00";
        query.Name = $('#queryTxtName').val();
        query.Email = $('#queryTxtMail').val();
        query.Subject = $('#queryTxtSubject').val();
        query.Message = $('#queryTxtMessage').val();

        $.ajax({
            type: 'POST',
            url: 'api/QueriesAPI',
            data: query,
            dataType: 'json',
            cache: false,
            success: function (data) {
                var outPut = '';
                outPut += '<hr/>Mensaje enviado<br/>';
                outPut += '<b>Fecha Consulta: <b/>' + query.Date + '<br/>';
                outPut += '<b>Nombre: <b/>' + query.Name + '<br/>';
                outPut += '<b>Email: <b/>' + query.Email + '<br/>';
                outPut += '<b>Asunto Consulta: <b/>' + query.Subject + '<br/>';
                outPut += '<b>Mensaje Consulta: <b/>' + query.Message + '<br/>';
                $('#queryLblMessage').html(outPut);
            },
            error: function (hxr, ajaxOptions, throwError) {
                $('#queryLblMessage').html('Error!');
            }
        });
        return false;
    });

    $('#btnAddVoluntary').on("click", function () {
        var volutaryName = $('#volutaryName').val();
        if (volutaryName == "") {
            $('#volutaryLblMessage').html('Debe ingresar un nombre...');
            return false;
        }
        var volutaryEmail = $('#volutaryEmail').val();
        if (volutaryEmail == "") {
            $('#volutaryLblMessage').html('Debe ingresar un E-Mail...');
            return false;
        }
        var volutaryPhone = $('#volutaryPhone').val();
        if (volutaryPhone == "") {
            $('#volutaryLblMessage').html('Debe ingresar un telefono...');
            return false;
        }
        var volutaryMessage = $('#volutaryMessage').val();
        if (volutaryMessage == "") {
            $('#volutaryLblMessage').html('Debe ingresar un mensaje...');
            return false;
        }

        var voluntary = new Object();
        voluntary.Date = "2000-01-01T00:00:00";
        voluntary.Name = $('#volutaryName').val();
        voluntary.Email = $('#volutaryEmail').val();
        voluntary.Phone = $('#volutaryPhone').val();
        voluntary.Message = $('#volutaryMessage').val();

        $.ajax({
            type: 'POST',
            url: 'api/VoluntariesAPI',
            data: voluntary,
            dataType: 'json',
            cache: false,
            success: function (data) {
                var outPut = '';
                outPut += '<hr/>Mensaje enviado<br/>';
                outPut += '<b>Fecha: <b/>' + voluntary.Date + '<br/>';
                outPut += '<b>Nombre: <b/>' + voluntary.Name + '<br/>';
                outPut += '<b>Email: <b/>' + voluntary.Email + '<br/>';
                outPut += '<b>Telefono: <b/>' + voluntary.Phone + '<br/>';
                outPut += '<b>Mensaje: <b/>' + voluntary.Message + '<br/>';
                $('#volutaryLblMessage').html(outPut);
            },
            error: function (hxr, ajaxOptions, throwError) {
                $('#volutaryLblMessage').html('Error!');
            }
        });
        return false;
    });

    $('#btnAddDonation').on("click", function () {
        var donationName = $('#donationName').val();
        if (donationName == "") {
            $('#donationLblMessage').html('Debe ingresar un nombre...');
            return false;
        }
        var donationEmail = $('#donationEmail').val();
        if (donationEmail == "") {
            $('#donationLblMessage').html('Debe ingresar un E-Mail...');
            return false;
        }
        var donationAmount = $('#donationAmount').val();
        if (donationAmount == "") {
            $('#donationLblMessage').html('Debe ingresar un monto...');
            return false;
        }
        var donationMessage = $('#donationMessage').val();
        if (donationMessage == "") {
            $('#donationLblMessage').html('Debe ingresar un mensaje...');
            return false;
        }

        var donation = new Object();
        donation.Date = "2000-01-01T00:00:00";
        donation.Name = $('#donationName').val();
        donation.Email = $('#donationEmail').val();
        donation.Amount = $('#donationAmount').val();
        donation.Message = $('#donationMessage').val();

        $.ajax({
            type: 'POST',
            url: 'api/DonationsAPI',
            data: donation,
            dataType: 'json',
            cache: false,
            success: function (data) {
                var outPut = '';
                outPut += '<hr/>Mensaje enviado<br/>';
                outPut += '<b>Fecha: <b/>' + donation.Date + '<br/>';
                outPut += '<b>Nombre: <b/>' + donation.Name + '<br/>';
                outPut += '<b>Email: <b/>' + donation.Email + '<br/>';
                outPut += '<b>Monto: <b/>' + donation.Subject + '<br/>';
                outPut += '<b>Mensaje: <b/>' + donation.Message + '<br/>';
                $('#donationLblMessage').html(outPut);
            },
            error: function (hxr, ajaxOptions, throwError) {
                $('#donationLblMessage').html('Error!');
            }
        });
        return false;
    });
    //$(document).ajaxStart(function () {
    //    $("#loading").show();
    //});
    //$(document).ajaxStop(function () {
    //    $("#loading").hide();
    //});
});