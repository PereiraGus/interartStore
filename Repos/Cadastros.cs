﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using interartStore.Repos;
using interartStore.Models;
using MySql.Data.MySqlClient;


namespace interartStore.Repos
{
    public class Cadastros
    {
        Connection con = new Connection();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarCliente(Cliente cli)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbcli values(@cliNome, @cliCPF, @cliNasc, @cliEmail, @cliEnd)", con.ConnectBD());
            cmd.Parameters.Add("@cliNome", MySqlDbType.VarChar).Value = cli.cliNome;
            cmd.Parameters.Add("@cliCPF", MySqlDbType.VarChar).Value = cli.cliCPF;
            cmd.Parameters.Add("@cliNasc", MySqlDbType.VarChar).Value = cli.cliNasc;
            cmd.Parameters.Add("@cliEmail", MySqlDbType.VarChar).Value = cli.cliEmail;
            cmd.Parameters.Add("@cliEnd", MySqlDbType.VarChar).Value = cli.cliEnd;
        }

        public void CadastrarFuncionario(Funcionario func)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbfunc values(@funcCod, @funcNome, @funcCPF, @funcRG, @funcEnd, @funcCel, @funcEmail, @funcCarg)", con.ConnectBD());
            cmd.Parameters.Add("@funcCod", MySqlDbType.VarChar).Value = func.funcCod;
            cmd.Parameters.Add("@funcNome", MySqlDbType.VarChar).Value = func.funcNome;
            cmd.Parameters.Add("@funcCPF", MySqlDbType.VarChar).Value = func.funcCPF;
            cmd.Parameters.Add("@funcRG", MySqlDbType.VarChar).Value = func.funcRG;
            cmd.Parameters.Add("@funcEnd", MySqlDbType.VarChar).Value = func.funcEnd;
            cmd.Parameters.Add("@funcCel", MySqlDbType.VarChar).Value = func.funcCel;
            cmd.Parameters.Add("@funcEmail", MySqlDbType.VarChar).Value = func.funcEmail;
            cmd.Parameters.Add("@funcCarg", MySqlDbType.VarChar).Value = func.funcCarg;
        }

        public void CadastrarJogo(Game gam)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbfunc values(@gameCod, @gameNome, @gameVer, @gameVer, @gameDev, @gameGen, @gameAge, @gameYear, @gameSinop)", con.ConnectBD());
            cmd.Parameters.Add("@gameCod", MySqlDbType.VarChar).Value = gam.gameCod;
            cmd.Parameters.Add("@gameNome", MySqlDbType.VarChar).Value = gam.gameNome;
            cmd.Parameters.Add("@gameVer", MySqlDbType.VarChar).Value = gam.gameVer;
            cmd.Parameters.Add("@gameDev", MySqlDbType.VarChar).Value = gam.gameDev;
            cmd.Parameters.Add("@gameGen", MySqlDbType.VarChar).Value = gam.gameGen;
            cmd.Parameters.Add("@gameAge", MySqlDbType.VarChar).Value = gam.gameAge;
            cmd.Parameters.Add("@gameYear", MySqlDbType.VarChar).Value = gam.gameYear;
            cmd.Parameters.Add("@gameSinop", MySqlDbType.VarChar).Value = gam.gameSinop;
        }

        public Cliente ListarCliCPF(string CPF)
        {
            var comando = String.Format("select * from tbCli where cliCPF = {0}", CPF);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConnectBD());
            var DadosCliCPF = cmd.ExecuteReader();
            return ListarCliCPF(DadosCliCPF).FirstOrDefault();
        }

        public List<Cliente> ListarCliCPF(MySqlDataReader dt)
        {
            var AtAl = new List<Cliente>();
            while(dt.Read())
            {
                var AlTemp = new Cliente()
                {
                    cliNome = dt["cliNome"].ToString(),
                    cliCPF = dt["cliCPF"].ToString(),
                    cliNasc = DateTime.Parse(dt["cliNasc"].ToString()),
                    cliEmail = dt["cliEmail"].ToString(),
                    cliEnd = dt["cliEnd"].ToString(),
                };
                AtAl.Add(AlTemp);
            }
            dt.Close();
            return AtAl;
        }

        public List<Cliente> ListarClientes()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbcli", con.ConnectBD());
            var DadosCli = cmd.ExecuteReader();
            return ListarTodosCli(DadosCli);
        }

        public List<Cliente> ListarTodosCli(MySqlDataReader dt)
        {
            var TodosCli = new List<Cliente>();
            while (dt.Read())
            {
                var CliTemp = new Cliente()
                {
                    cliNome = dt["cliNome"].ToString(),
                    cliCPF = dt["cliCPF"].ToString(),
                    cliNasc = DateTime.Parse(dt["cliNasc"].ToString()),
                    cliEmail = dt["cliEmail"].ToString(),
                    cliEnd = dt["cliEnd"].ToString(),
                };
                TodosCli.Add(CliTemp);
            }
            dt.Close();
            return TodosCli;
        }
    }
}