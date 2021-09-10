using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace interart.Models
{
    public class JogosModel
    {
        [Display(Name = "Código do jogo:")]
        [Required(ErrorMessage = "Assimile um código para o jogo.")]
        public int gameCod { get; set; }

        [Display(Name = "Nome do jogo:")]
        [Required(ErrorMessage = "Informe o nome do jogo.")]
        public string gameNome { get; set; }

        [Display(Name = "Versão do jogo (se houver):")]
        public string gameVer { get; set; }

        [Display(Name = "Desenvolvedora do jogo:")]
        [Required(ErrorMessage = "Informe a desenvolvedora do jogo.")]
        public string gameDev { get; set; }

        [Display(Name = "Gênero do jogo:")]
        [Required(ErrorMessage = "Informe o gênero do jogo.")]
        public string gameGen { get; set; }

        [Display(Name = "Faixa etária do jogo:")]
        [Required(ErrorMessage = "Informe uma faixa etária para o jogo.")]
        public string gameAge { get; set; }

        [Display(Name = "Ano de lançamento do jogo:")]
        [Required(ErrorMessage = "Informe o ano de lançamento do jogo.")]
        [Range(1970, 2022, ErrorMessage = "Digite um ano válido.")]
        public int gameYear { get; set; }

        [Display(Name = "Sinopse do jogo:")]
        [Required(ErrorMessage = "Informe a sinopse do jogo.")]
        public string gameSinop { get; set; }
    }
}