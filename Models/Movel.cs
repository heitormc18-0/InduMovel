using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace InduMovel.Models
{
    public class Movel 
    {
        public int MovelId { get; set; }
        [Required(ErrorMessage = "Informe o nome do Movel")]
        [Display(Name = "Movel")]
        [MinLength(3, ErrorMessage = "Movel deve ter no minimo {1} caracters")]
        [MaxLength (30, ErrorMessage = "Movel deve ter no máximo {1} caracters")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o nome da Descrição")]
        [Display(Name = "Descrição")]
        [MinLength(3, ErrorMessage = "Descrição deve ter no minimo {1} caracters")]
        [MaxLength (320, ErrorMessage = "Descrição deve ter no máximo {1} caracters")]
        public string Desricao { get; set; }
        [Display(Name ="Cor")]
        [MaxLength(20, ErrorMessage = "Cor deve ter no máximo {1} caracters")]
        public string Cor { get; set; }
        [Display(Name ="Caminho da Imagem")]
        public string ImagemUrl { get; set;}
        [Display(Name ="Caminho da imagem pequena")]
        public string ImagemPequena { get; set; }
        [Required(ErrorMessage ="Informe o valor")]
        [Display(Name ="Valor")]
        [Range(1,99999.99, ErrorMessage ="O valor de estar entre {1} e {2}")]
        public double Valor { get; set; }
        [Display(Name = "Em linha de produção")]
        public bool EmProducao { get; set; }
        [Display(Name ="Ativo")]
        public bool Ativo { get; set; }
        [Required(ErrorMessage ="Informe a categoria")]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}