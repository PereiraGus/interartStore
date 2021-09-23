using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace interartStore.Models
{
    public class Cliente
    {
        [Display(Name = "Nome do cliente:")]
        [Required(ErrorMessage = "Informe o nome do cliente.")]
        public string cliNome { get; set; }

        [Display(Name = "CPF do cliente:")]
        [Required(ErrorMessage = "Informe o CPF do cliente.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Valor inválido")]
        public string cliCPF { get; set; }

        [Display(Name = "Data de nascimento do cliente:")]
        [Required(ErrorMessage = "Informe a data de nascimento do cliente.")]
        public DateTime cliNasc { get; set; }

        [Display(Name = "Email do cliente:")]
        [Required(ErrorMessage = "Informe o email do cliente.")]
        [RegularExpression(@"\w+([-+.']\w+)@\w+([-.]\w+)\.\w+([-.]\w+)*", ErrorMessage = "Email inválido")]
        public string cliEmail { get; set; }

        [Display(Name = "Telefone celular do cliente:")]
        [Required(ErrorMessage = "Informe o telefone celular do cliente.")]
        [RegularExpression(@"(\(?\d{2}\)?\s)?(\d{4,5}\-\d{4})", ErrorMessage = "Telefone inválido")]
        public string cliCel { get; set; }

        [Display(Name = "Endereço do cliente:")]
        [Required(ErrorMessage = "Informe o endereço do cliente.")]
        public string cliEnd { get; set; }
    }
}