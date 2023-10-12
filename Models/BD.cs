using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Dapper;

namespace TP10_CZERNUSZKA_KOZIUPA.Models;

public static class BD{
    private static string _connectionString = @"Server=localhost;DataBase=BDSeries;Trusted_Connection=True;";

    public static List<Series> ObtenerSeries(){
        List<Series> listaSeries = null;
        using(SqlConnection BD = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Series";
            listaSeries = BD.Query<Series>(sql).ToList();
        }
        return listaSeries;
    }
    public static List<Temporadas> ObtenerTemporada(int IdSerie){
        Temporadas temporada = null;
        using(SqlConnection BD = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Temporadas WHERE IdSerie = @IdSerie";
            temporada = BD.QueryFirstOrDefault<Temporadas>(sql)
        }
    }

}
