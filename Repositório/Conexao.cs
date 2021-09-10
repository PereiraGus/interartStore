using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace interart2.Repositório
{
    public class Conexao
    {
        MySqlConnection cn = new MySqlConnection("Server=localhost;DataBase=DBINTERART;user=root;pwd=Negocios1.");
        public static string msg;
        public MySqlConnection ConnectBD()
        {
            try
            {
                cn.Open();
            }
            catch(Exception error)
            {
                msg = "Ocorreu um erro a conectar" + error.Message;
            }
            return cn;
        }
        public MySqlConnection DisconnectBD()
        {
            try
            {
                cn.Close();
            }
            catch (Exception error)
            {
                msg = "Ocorreu um erro ao desconectar" + error.Message;
            }
            return cn;
        }
    }
}