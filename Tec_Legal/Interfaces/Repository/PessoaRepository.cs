using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Tec_Legal.Models;

namespace Tec_Legal.Interfaces.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        public readonly string _connectionString;
        public PessoaRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ConexaoNuvem");
        
        }

        public List<MatchResult> BuscarMatch(string areaInteresse, string localizacao)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var pessoas = connection.Query<PersonModel>("SELECT * FROM Persons").ToList();

                var resultados = pessoas.Select(p => new MatchResult
                {
                    Nome = p.Nome,
                    AreaInteresse = p.AreaInteresse,
                    Localizacao = p.Localizacao,
                    Descricao = p.Descricao,
                    Afinidade = CalcularAfinidade(p, areaInteresse, localizacao)
                })
            .OrderByDescending(x => x.Afinidade)
            .Take(3)
            .ToList();

                return resultados;

            }

        }

        private int CalcularAfinidade(PersonModel p, string interesse, string local)
        {
            int afinidade = 50;
            if (p.AreaInteresse.Equals(interesse, StringComparison.OrdinalIgnoreCase))
                afinidade += 30;

            if (p.Localizacao.Equals(local, StringComparison.OrdinalIgnoreCase))
                afinidade += 20;

            return Math.Min(afinidade, 100);
        }





    }
}
