using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuApp.Models;

[Table("Lanches")]
public class Lanche
{
    [Key]
    public int Id { get; set; }

    [StringLength(100, ErrorMessage = "O tamanho máximo é 100 carácteres!")]
    [Display(Name = "Nome do Lanche")]
    [Required(ErrorMessage = "Informe o nome do lanche!")]
    public string Nome { get; set; }

    [StringLength(200, ErrorMessage = "O tamanho máximo é 200 carácteres!")]
    [Required(ErrorMessage = "Informe uma descrição para o lanche!")]
    public string DescricaoCurta { get; set; }

    [StringLength(400, ErrorMessage = "O tamanho máximo é 400 carácteres!")]
    [Required(ErrorMessage = "Informe uma descrição para o lanche!")]
    public string DescricaoLonga { get; set; }

    [Display(Name = "Caminho Imagem Normal")]
    [StringLength(200, ErrorMessage = "O tamanho máximo é 200 carácteres!")]
    public string UrlImagem { get; set; }

    [Display(Name = "Caminho Imagem Miniatura")]
    [StringLength(200, ErrorMessage = "O tamanho máximo é 200 carácteres!")]
    public string UrlImagemThumbnail { get; set; }

    [Required(ErrorMessage = "Informe o preço do lanche!")]
    [Column(TypeName = "decimal(10,2)")]
    [Range(1,999.99, ErrorMessage = "O preço deve estar entre 1 e 999.99")]
    [Display(Name = "Preço")]
    public decimal Preco { get; set; }

    [Display(Name = "Favorito?")]
    public bool IsFavorito { get; set; }
    [Display(Name = "Estoque")]
    public bool IsEmEstoque { get; set; }
    public Categoria Categoria { get; set; }

}
