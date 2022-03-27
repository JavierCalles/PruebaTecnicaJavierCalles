

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




