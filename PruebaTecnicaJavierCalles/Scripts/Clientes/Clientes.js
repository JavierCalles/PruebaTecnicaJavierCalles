

function Insertar() {


    var DocIdenti = $("#txtDocumento").val();
    var PrNom = $("#txtPrNombre").val();
    var PrApe = $("#txtPrApe").val();
    var Edad = $("#txtEdad").val();


    if (DocIdenti != "" && PrNom != "" && PrApe != "" && Edad != "") {
        if (DocIdenti.length > 4) {
            if (Edad <= 150 && Edad >= 5) {

                $.get(UrlInsertar,
                    {
                        DocIdenti: DocIdenti,
                        PrNom: PrNom,
                        PrApe: PrApe,
                        Edad: Edad
                    })
                    .done(function (data) {
                        $("#txtDocumento").val('');
                        $("#txtPrNombre").val('');
                        $("#txtPrApe").val('');
                        $("#txtEdad").val('');

                        location.reload();

                    }).fail(function () {
                        alert("Error al ingresar cliente");
                    });
            } else
                {
                alert("La edad debe ser entre 5 y 150 años.");
                }
        } else {
            alert("El documento de identidad debe tener al menos 5 digitos.");
        }
    } else {
        alert("Debe completar todos los campos");
    }
    
}



function Actualizar() {


    var DocIdenti = $("#txtDocumentoUpdate").val();
    var PrNom = $("#txtPrNombreUpdate").val();
    var PrApe = $("#txtPrApeUpdate").val();
    var Edad = $("#txtEdadUpdate").val();
    var IdCliente = $("#txtIdCliente").val();

    if (DocIdenti != "" && PrNom != "" && PrApe != "" && Edad != "") {
        if (DocIdenti.length > 4) {
            if (Edad <= 150 && Edad >= 5) {


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

            } else {
                alert("La edad debe ser entre 5 y 150 años.");
            }
        } else {
            alert("El documento de identidad debe tener al menos 5 digitos.");
        }
    } else {
        alert("Debe completar todos los campos");
    }

}


function eliminar(IdCliente) {




    $.post(UrlDelete,
        {
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




