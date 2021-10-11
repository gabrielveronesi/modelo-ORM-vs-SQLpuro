using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ModeloORMxSQL.Core.Data;
using ModeloORMxSQL.Core.Models;

namespace ModeloORMxSQL.Core.Repositories
{
    public class ClienteRepository
    {
        private readonly DataContext _context;
        public ClienteRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Cliente>> ListarClientesCadastradosComORM()
        {
            var clientes = await _context.Clientes.ToListAsync();

            return clientes;
        }
        public List<Cliente> ListarClientesCadastradosComSQL()
        {
            using (var con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Teste_ORM_SQL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                //DynamicParameters parameters = new DynamicParameters();
                //parameters.Add("@ID_Banco", idBanco);

                string sql = @"SELECT *
                               FROM Clientes";

                var Retorno = con.Query<Cliente>(sql: sql,
                                                 commandType: CommandType.Text).ToList();

                return Retorno;
            }
        }

    }
}