using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSistemaDePedidos.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Required]
        [StringLength(200)]
        [Key]
        public string CodigoDoProduto { get; set; }

        [Required]
        [StringLength(500)]
        public string DescriçãoDoProduto { get; set; }

        public DateTime DataDeCadastroDoProduto { get; set; }

        public int ValorDoProduto { get; set; }


    }
}
