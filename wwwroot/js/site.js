function MostrarTemporadas(id,nombre){
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/MostrarTemporadasAjax',
            data: {IdSerie: id},
            success:
            function (response)
            {
                console.log(response);
                $("#titulo").html("Temporadas de la serie " + nombre);
                let texto = "";
                for(let item of response){
                    texto += (item.numeroTemporada+ ". "+item.tituloTemporada + "<br>") ;
                }
                $("#info").html(texto)
            }
        });
}

function MostrarActores(id,nombre){
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/MostrarActoresAjax',
            data: {IdSerie: id},
            success:
            function (response)
            {
                $("#titulo").html("Actores de la serie " + nombre);
                let texto = "";
                for(let item of response){
                    texto += item.nombre + "<br>";
                }
                $("#info").html(texto)
            }
        });
}
    
function MostrarInfo(id,nombre){
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/MostrarInfoAjax',
            data: {IdSerie: id},
            success:
            function (response)
            {
                $("#titulo").html("Info de la serie " + nombre);
                $("#info").html(response)
            }
        });
}