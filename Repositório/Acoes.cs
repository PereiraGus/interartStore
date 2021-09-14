using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using interart2.Repositório;
using interart2.Models;

namespace interart2.Repositório
{
    public class Acoes
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
    }

    public void CadastrarCliente(ClienteModel, cli)
    {
        MySqlCommand cmd = new MySqlCommand("insert into tbcli values(@cliNome, @cliCPF, @cliNasc, @cliEmail, @cliEnd)", con ConnectBD());
        cmd.Parameters.Add("@cliNome", MySqlDbType.VarChar).Value = cli.CliNome;
        cmd.Parameters.Add("@cliCPF", MySqlDbType.VarChar).Value = cli.CliCPF;
        cmd.Parameters.Add("@cliNasc", MySqlDbType.VarChar).Value = cli.CliNasc;
        cmd.Parameters.Add("@cliEmail", MySqlDbType.VarChar).Value = cli.CliEmail;
        cmd.Parameters.Add("@cliEnd", MySqlDbType.VarChar).Value = cli.CliEnd;
    }

    public void CadastrarFuncionario(FuncionarioModel, func)
    {
        MySqlCommand cmd = new MySqlCommand("insert into tbfunc values(@funcCod, @funcNome, @funcCPF, @funcRG, @funcEnd, @funcCel, @funcEmail, @funcCarg)", con ConnectBD());
        cmd.Parameters.Add("@funcCod", MySqlDbType.VarChar).Value = func.FuncCod;
        cmd.Parameters.Add("@funcNome", MySqlDbType.VarChar).Value = func.FuncNome;
        cmd.Parameters.Add("@funcCPF", MySqlDbType.VarChar).Value = func.FuncCPF;
        cmd.Parameters.Add("@funcRG", MySqlDbType.VarChar).Value = func.FuncRG;
        cmd.Parameters.Add("@funcEnd", MySqlDbType.VarChar).Value = func.FuncEnd;
        cmd.Parameters.Add("@funcCel", MySqlDbType.VarChar).Value = func.FuncCel;
        cmd.Parameters.Add("@funcEmail", MySqlDbType.VarChar).Value = func.FuncEmail;
        cmd.Parameters.Add("@funcCarg", MySqlDbType.VarChar).Value = func.FuncCarg;
    }

    public void CadastrarJogo(JogosModel, gam)
    {
        MySqlCommand cmd = new MySqlCommand("insert into tbfunc values(@gameCod, @gameNome, @gameVer, @gameVer, @gameDev, @gameGen, @gameAge, @gameYear, @gameSinop)", con ConnectBD());
        cmd.Parameters.Add("@gameCod", MySqlDbType.VarChar).Value = gam.gameCod;
        cmd.Parameters.Add("@gameNome", MySqlDbType.VarChar).Value = gam.gameNome;
        cmd.Parameters.Add("@gameVer", MySqlDbType.VarChar).Value = gam.gameVer;
        cmd.Parameters.Add("@gameDev", MySqlDbType.VarChar).Value = gam.gameDev;
        cmd.Parameters.Add("@gameGen", MySqlDbType.VarChar).Value = gam.gameGen;
        cmd.Parameters.Add("@gameAge", MySqlDbType.VarChar).Value = gam.gameAge;
        cmd.Parameters.Add("@gameYear", MySqlDbType.VarChar).Value = gam.gameYear;
        cmd.Parameters.Add("@gameSinop", MySqlDbType.VarChar).Value = gam.gameSinop;
    }


}