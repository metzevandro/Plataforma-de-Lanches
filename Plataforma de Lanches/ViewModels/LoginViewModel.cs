using System.ComponentModel.DataAnnotations;

namespace Plataforma_de_Lanches.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Por favor, informe o nome de usuário.")]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Por favor, informe a senha.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
