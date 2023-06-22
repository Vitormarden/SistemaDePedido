using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace ApiSistemaDePedidos.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Key]
        public string Cnpj { get; set; }
        [Required]
        [StringLength(200)]
        public string RazaoSocial { get; set; }
        [Required]
        [StringLength(200)]
        public string Nf { get; set; }
        [Required]
        [StringLength(100)]
        public string EmailFornecedor { get; set; }
        [Required]
        [StringLength(200)]
        public string NomeFornecedor { get; set; }
    }
}
