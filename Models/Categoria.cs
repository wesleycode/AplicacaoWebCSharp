﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuApp.Models;

[Table("Categorias")]
public class Categoria
{
    [Key]
    public int Id { get; set; }
    [StringLength(100, ErrorMessage = "O tamanho máximo é 100 carácteres!")]
    [Required(ErrorMessage = "Informe o nome da categoria!")]
    public string Nome { get; set; }
    [StringLength(200, ErrorMessage = "O tamanho máximo é 200 carácteres!")]
    [Required(ErrorMessage = "Informe a descrição da categoria!")]
    public string Descricao { get; set; }
    public List<Lanche> Lanches { get; set; }
}
