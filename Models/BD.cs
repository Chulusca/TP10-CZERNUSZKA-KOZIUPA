using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Dapper;

namespace TP10_CZERNUSZKA_KOZIUPA.Models;

public static class BD{
    private static string _connectionString = @"Server=localhost;DataBase=BDSeries;Trusted_Connection=True;";

    public static List<Usuario> ObtenerSeries(){
        List<Usuario> listaSeries = null;
        using(SqlConnection BD = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Series";
            listaUsuarios = BD.Query<Usuario>(sql).ToList();
        }
        return listaUsuarios;
    }

}