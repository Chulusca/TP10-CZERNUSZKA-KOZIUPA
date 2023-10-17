function MostrarSerie(IdS)
{
    $.ajax(
        {
            type: "POST",
            dataType: "JSON",
            url: 'Home/MostrarSerieAjax',
            data: {IdSerie: IdS},
            success: function (data) {
                $("#NombreSerie").html(response.Nombre);
                $("#Sinopsis").html("Sinopsis: " + response.Sinopsis);
                $("#AnoInicio").html("Comenzo en: " + response.Fecha);
                $("#FotoSerie").attr("src", response.Imagen);
            }
        }); 
}