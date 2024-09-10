using System.ComponentModel.DataAnnotations;

namespace AppFluxoDeCaixa.Models
{
    public class Fornecedor
    {
        public Guid FornecedorId { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Campo Nome É Obrigatório!")]
        [MaxLength(100, ErrorMessage = "O Limite do Campo é de 100 Dígitos!")]
        [MinLength(3, ErrorMessage = "O Campo Nome deve ter no mínimo 3 caracteres!")]
        public string Nome { get; set; }
        [Display(Name = "CNPJ")]
        [Required(ErrorMessage = "Insira seu CNPJ!")]
        public string CNPJ { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O Campo E-mail É Obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Campo Telefone É Obrigatório!")]
        [MaxLength(11, ErrorMessage = "O Limite do campo é de 11 Dígitos Numéricos!")]
        [MinLength(10, ErrorMessage = "O Campo deve ter pelo menos 10 dígitos Numéricos")]
        public string Telefone { get; set; }
        [Display(Name = "Data de Cadastro")]
        [Required(ErrorMessage = "O Campo Data de Cadastro é obrigatório!")]
        public DateTime DataCadastro { get; set; }
        [Display(Name = "Fornecedor Ativo?")]
        public bool Ativo { get; set; }
    }
}
