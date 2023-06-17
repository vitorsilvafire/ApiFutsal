using ApiFutsal.Models.Enuns;
namespace ApiFutsal.Models
{
    public class Jogadores
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Responsavel { get; set; }
        public PosicaoEnum Posicao { get; set; }
        public string CPF { get; set; }
    }
}