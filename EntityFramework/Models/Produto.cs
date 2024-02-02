using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }
        [Required]
        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; }
        
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
