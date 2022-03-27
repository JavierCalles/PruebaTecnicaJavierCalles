

function Insertar() {


    var DocIdenti = $("#txtDocumento").val();
    var PrNom = $("#txtPrNombre").val();
    var PrApe = $("#txtPrApe").val();
    var Edad = $("#txtEdad").val();



    $.get(UrlInsertar,
        {
            DocIdenti: DocIdenti,
            PrNom: PrNom,
            PrApe: PrApe,
            Edad: Edad
            })
            .done(function(data) {
                $("#txtDocumento").val('');
                $("#txtPrNombre").val('');
                $("#txtPrApe").val('');
                $("#txtEdad").val('');

                location.reload();

            }).fail(function () {
                alert("Error al ingresar cliente");
            });

    
}



function Actualizar() {


    var DocIdenti = $("#txtDocumentoUpdate").val();
    var PrNom = $("#txtPrNombreUpdate").val();
    var PrApe = $("#txtPrApeUpdate").val();
    var Edad = $("#txtEdadUpdate").val();
    var IdCliente = $("#txtIdCliente").val();


    $.post(UrlUpdate,
        {
            DocIdenti: DocIdenti,
            PrNom: PrNom,
            PrApe: PrApe,
            Edad: Edad,
            IdCliente: IdCliente
        })
        .done(function (data) {
            
            location.reload();

        }).fail(function () {
            alert("Error al actualizar cliente");
        });


}


function mostrarModal(idcliente,Documento, Nombre, Apellido, Edad) {

    $("#txtIdDocumento").val(Documento);
    $("#txtDocumentoUpdate").val(Documento);
    $("#txtPrNombreUpdate").val(Nombre);
    $("#txtPrApeUpdate").val(Apellido);
    $("#txtEdadUpdate").val(Edad);
    $("#txtIdCliente").val(idcliente);


    $('#modalUpdateCliente').modal('show');

}




