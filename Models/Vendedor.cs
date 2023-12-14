using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Francisco_Thiago.Models
{
    public class Vendedor
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "NOME")]
        public string ?Nome { get; set; }
    }
}