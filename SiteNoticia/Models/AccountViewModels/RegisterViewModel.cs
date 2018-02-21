using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteNoticia.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Nome de usuario obrigatório")]
        [DataType(DataType.Text)]
        [Display(Name = "Nome")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A senha deve ter no mínimo {2} caracteres.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha")]
        [Compare("Password", ErrorMessage = "A senha e confirmção não conferem.")]
        public string ConfirmPassword { get; set; }
    }
}
