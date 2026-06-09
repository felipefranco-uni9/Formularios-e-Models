using System;
using System.ComponentModel.DataAnnotations;

namespace Formulario.Models 
{
    public class Aluno
    {
        [Required(ErrorMessage = "O Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O Nome deve ter no máximo 100 caracteres.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Formato de e-mail inválido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O RA é obrigatório.")]
        [StringLength(10, ErrorMessage = "O RA deve ter no máximo 10 caracteres.")]
        public string? RA { get; set; }

        [Required(ErrorMessage = "O Curso é obrigatório.")]
        public string? Curso { get; set; }

        [Required(ErrorMessage = "A Data de Nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}
