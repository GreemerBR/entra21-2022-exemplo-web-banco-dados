using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio
{
    public class RacaRepositorio : IRacaRepositorio
    {
        // Essa linha aqui que permite fazer as coisas tudo no banco de forma mais simples
        private readonly ClinicaVeterinariaContexto _contexto;

        public RacaRepositorio(ClinicaVeterinariaContexto contexto)
        {
            _contexto = contexto;
        }
        public void Cadastrar(Raca raca)
        {
            // INSERT NA TABELA DE RAÇAS
            _contexto.Racas.Add(raca);
            _contexto.SaveChanges();
        }
    }
}
