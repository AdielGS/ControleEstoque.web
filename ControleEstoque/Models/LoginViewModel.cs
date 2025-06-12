using System.ComponentModel.DataAnnotations;

public class LoginViewModel
{
    [Required(ErrorMessage = "O usuário é obrigatório.")]
    public string Usuario { get; set; }

    [Required(ErrorMessage = "A senha é obrigatória.")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    public bool LembreMe { get; set; }
}
