using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Persistencia.Repositorios
{
    public class ConexionDB
    {    
        public static MySqlConnection GetConexion()
        {
            string cadenaConexion = "Database=prueba02; Data Source=localhost; Port=3306; User Id=pppp; Password=pppp";
            MySqlConnection conexion = null;
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                Console.WriteLine("something is ");
            }catch (MySqlException ex){
                string mensaje = ex.ToString();
                Console.WriteLine("something is "+ex.ToString());
            }
            finally
            {
                Console.WriteLine("\n");
            }
            return conexion;        
        } 
    }
}
