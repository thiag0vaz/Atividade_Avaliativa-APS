using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Francisco_Thiago.Models
{
    public class PagamentoComCartao : TipoDePagamento
    {
        [Display(Name = "NUMERO DO CARTAO")]
        public string ?NumeroDoCartao { get; set; }
        [Display(Name = "BANDEIRA")]
        public string ?Bandeira { get; set; }
    }
}