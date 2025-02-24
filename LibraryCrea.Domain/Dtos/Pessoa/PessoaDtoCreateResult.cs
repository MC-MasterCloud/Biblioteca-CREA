﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Domain.Dtos.Pessoa
{
    public class PessoaDtoCreateResult
    {
        
        //isUniq
        [Display(Name = "Matricula", Description = "Matricula da Pessoa")]
        [Required(ErrorMessage = "Matrícula Deve Ser Obrigatória")]
        public string Matricula { get; set; }

        [Display(Name = "Nome", Description = "Nome da Pessoa")]
        [Required(ErrorMessage = "Nome da Pessoa é Obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "RG", Description = "RG Pessoa")]
        [Required(ErrorMessage = "O RG da Pessoa Deve ser Obrigtório")]
        public int RG { get; set; }

        [Display(Name = "CPF", Description = "CPF Pessoa")]
        [Required(ErrorMessage = "O CPF Deve Ser Obrigatório")]
        [RegularExpression(@"^\d$",
            ErrorMessage = "O CPF Deve Conter Apenas Números")]
        public string CPF { get; set; }

        public Tipo tipo { get; set; }
        public enum Tipo
        {
            Autor,
            Profissional,
            Aluno,
            Outros
        }

        public bool Ativo { get; set; }

        public IEnumerable<DadosParaContato> dadosParaContato { get; set; }

        public DateTime CreateAt { get; set; }
    }
}
