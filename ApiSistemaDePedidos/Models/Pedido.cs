using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSistemaDePedidos.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        public int CodigoDoPedido { get; set; }

        public DateTime DataDoPedido { get; set; }
        [Required]
        [StringLength(100)]
        [ForeignKey("Produto")]
        public string ProdutoDoPedido { get; set; }

        public int QuantidadeDeProdutoNoPedido { get; set; }
        [Required]
        [StringLength(200)]
        [ForeignKey("Fornecedor")]
        public string Fornecedor { get; set; }

        public int  ValorTotalDoPedido { get; set; }
    }
}
