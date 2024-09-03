using System.ComponentModel.DataAnnotations;

namespace AppFluxoDeCaixa.Models
{
    public class Clientes
    {
        public Guid ClientesId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Campo Nome É Obrigatório!")]
        [MaxLength(100, ErrorMessage = "O Limite do Campo é de 100 Dígitos!")]
        [MinLength(3, ErrorMessage = "O Campo Nome deve ter no mínimo 3 caracteres!")]
        public string ClientesNome { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "O Campo Endereço É Obrigatório!")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "O Campo Cidade É Obrigatório!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O Campo UF É Obrigatório!")]
        [MaxLength(2, ErrorMessage = "O Limite do campo é 2 caracteres! Ex: SP")]
        [MinLength(2, ErrorMessage = "O Campo deve ter 2 caracteres! Ex: SP")]
        public string UF { get; set; }

        [Required(ErrorMessage = "O Campo CEP É Obrigatório!")]
        [MaxLength(8, ErrorMessage = "O Limite do campo é de 8 Dígitos Numéricos!")]
        [MinLength(8, ErrorMessage = "O Campo deve ter 8 dígitos Numéricos")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O Campo Bairro É Obrigatório!")]
        public string Bairro { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "O Campo Número é obrigatório!")]
        public string Numero { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O Campo E-mail É Obrigatório!")]

        public string Email { get; set; }


        [MaxLength(10, ErrorMessage = "O Limite do campo é de 10 Dígitos Numéricos!")]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "O Campo Celular É Obrigatório!")]
        [MaxLength(11, ErrorMessage = "O Limite do campo é de 11 Dígitos Numéricos!")]
        [MinLength(11, ErrorMessage = "O Campo deve ter 11 dígitos Numéricos")]
        public string Celular { get; set; }

        [Display(Name = "Tipo de pessoa")]
        [Required(ErrorMessage = "Insira o Tipo de pessoa!")]
        public string TipoPessoa { get; set; }
        [Display(Name = "CPF/CNPJ")]
        [Required(ErrorMessage = "Insira seu CPF ou CNPJ!")]

        public string CpfCnpj { get; set; }

        [Display(Name = "Data de Cadastro")]
        [Required(ErrorMessage = "O Campo Data de Cadastro é obrigatório!")]
        public DateTime DataCadastro { get; set; }
        [Display(Name = "Data Nasc. / Fundação")]
        [Required(ErrorMessage = "O Campo é obrigatório!")]
        public DateOnly DataNascFundacao { get; set; }
        [Display(Name = "Inscrição Ativa?")]
        public bool CadastroAtivo { get; set; }
        [Display(Name = "Observação")]
        [MaxLength(255, ErrorMessage = "O limite é de 255 caracteres")]

        public string? Obervacao { get; set; }



    }
}
