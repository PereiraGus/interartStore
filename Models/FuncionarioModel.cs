using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace interart.Models
{
    public class FuncionarioModel
    {
        [Display(Name = "Código do funcionário:")]
        [Required(ErrorMessage = "Informe um código para o funcionário.")]
        public int funcCod { get; set; }

        [Display(Name = "Nome do funcionário:")]
        [Required(ErrorMessage = "Infome um nome para o funcionário.")]
        public string funcNome { get; set; }

        [Display(Name = "CPF do funcionário:")]
        [Required(ErrorMessage = "Infome o CPF do funcionário.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Valor inválido")]
        public string funcCPF { get; set; }

        [Display(Name = "RG do funcionário:")]
        [Required(ErrorMessage = "Informe o RG do funcionário.")]
        public int funcRG { get; set; }

        [Display(Name = "Data de nascimento do funcionário:")]
        [Required(ErrorMessage = "Infome a data de nascimento do funcionário.")]
        public DateTime funcNasc { get; set; }

        [Display(Name = "Endereço do funcionário:")]
        [Required(ErrorMessage = "Informe o endereço do funcionário.")]
        public string funcEnd { get; set; }

        [Display(Name = "Telefone celular do funcionário:")]
        [Required(ErrorMessage = "Infome o telefone celular do cliente.")]
        public string funcCel { get; set; }

        [Display(Name = "Email do funcionário:")]
        [Required(ErrorMessage = "Informe o email do funcionário.")]
        [RegularExpression(@"\w+([-+.']\w+)@\w+([-.]\w+)\.\w+([-.]\w+)*", ErrorMessage = "Email inválido")]
        public string funcEmail { get; set; }

        [Display(Name = "Cargo do funcionário:")]
        [Required(ErrorMessage = "Selecione o cargo do funcionário.")]
        public string funcCarg { get; set; }
    }
}