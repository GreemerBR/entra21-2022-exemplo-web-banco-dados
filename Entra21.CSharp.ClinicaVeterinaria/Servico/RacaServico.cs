using Entra21.CSharp.ClinicaVeterinaria.Repositorio;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico
{
        /* A classe RacaServico irá implementar a interface IRacaService,
         ou seja, deverá honrar as clausulas definidos na interface (contrato) */

    public class RacaServico : IRacaServico
    {
        private readonly RacaRepositorio _racaRepositorio;

        public RacaServico(ClinicaVeterinariaContexto contexto)
        {
            _racaRepositorio = new RacaRepositorio(contexto);
        }

        public void Cadastrar(string nome, string especie)
        {
            var raca = new Raca();
            raca.Nome = nome;
            raca.Especie = especie;

            _racaRepositorio.Cadastrar(raca);

            Console.WriteLine($"Nome: {nome} Espécie: {especie}");
        }
    }
}
