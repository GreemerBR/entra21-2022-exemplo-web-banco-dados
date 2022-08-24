namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades
{
    public class Veterinario : EntidadeBase
    {
        public int? Idade { get; set; }
        public string Nome { get; set; }
        public string Crmv { get; set; }
        public decimal? Salario { get; set; }
        public bool Empregado { get; set; }
    }
}
