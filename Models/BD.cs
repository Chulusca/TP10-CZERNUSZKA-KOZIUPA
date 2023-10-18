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
    public static List<Temporadas> ObtenerTemporadas(int IdSerie){
        List<Temporadas> temporadas = null;
        using(SqlConnection BD = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Temporadas WHERE IdSerie = @IdSerie";
            temporadas = BD.Query<Temporadas>(sql, new {IdSerie = IdSerie}).ToList();
        }
        return temporadas;
    }
    public static Series ObtenerSerie(int IdSerie){
        Series serie = null;
        using(SqlConnection BD = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Series WHERE IdSerie = @IdSerie";
            serie = BD.QueryFirstOrDefault<Series>(sql, new {IdSerie = IdSerie});
        }
        return serie;
    }
    public static List<Actores> ObtenerActores(int IdSerie){
        List<Actores> actores = null;
        using(SqlConnection BD = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Actores WHERE IdSerie = @IdSerie";
            actores = BD.Query<Actores>(sql, new {IdSerie = IdSerie}).ToList(); 
        }
        return actores;
    }
}
