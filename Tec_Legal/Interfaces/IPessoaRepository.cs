using Tec_Legal.Models;

namespace Tec_Legal.Interfaces
{
    public interface IPessoaRepository
    {
        /// <summary>
        /// Busca e retorna uma lista de resultados de correspondência com base na área de interesse e localização informadas.
        /// </summary>
        /// <param name="areaIntersse">A área de interesse utilizada como critério de busca (ex: "Tecnologia", "Marketing").</param>
        /// <param name="localizacao">A localização desejada para o filtro dos resultados (ex: "São Paulo", "Remoto").</param>
        /// <returns>
        /// Uma lista de objetos <see cref="MatchResult"/> que representam as correspondências encontradas de acordo com os critérios fornecidos.
        /// Se nenhum resultado for encontrado, a lista retornada estará vazia.
        /// </returns>
        List<MatchResult> BuscarMatch(string areaIntersse, string localizacao);


    }
}
