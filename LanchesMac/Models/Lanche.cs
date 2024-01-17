using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        public int Id { get; set; }

        [Required(ErrorMessage =("O nome do lanche deve ser informado"))]
        [Display(Name ="Nome do lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage ="O {0} deve conter no mínimo {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = ("A descrição do lanche deve ser informada"))]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20, ErrorMessage = "A descrição deve conter no mínimo {0} caracteres")]
        [MaxLength(200, ErrorMessage = "A descrição não pode exceder {0} caracteres")]
        public string DescricaoCurta { get; set; }
        [Required(ErrorMessage = ("A descrição detalhada deve ser informada"))]
        [Display(Name = "Descrição detalhada do Lanche")]
        [MinLength(20, ErrorMessage = "A descrição detalhada deve conter no mínimo {0} caracteres")]
        [MaxLength(200, ErrorMessage = "A descrição detalhada não pode exceder {0} caracteres")]
        public string DescricaoDetalhada { get; set; }
        [Required(ErrorMessage =("Informe o preço do lanche"))]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.999, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }
        [Display(Name = "Caminho da imagem normal")]
        [StringLength(200, ErrorMessage = "O {0} deve conter no máximo {1} Caracteres")]
        public string ImagemUrl { get; set; }
        [Display(Name = "Caminho da imagem miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve conter no máximo {1} Caracteres")]
        public string ImagemThumbnailUrl { get; set; }
        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }
        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }


    }
}
