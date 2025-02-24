﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Domain.Entities
{
    public class CadastroCategoriaEntity : BaseEntity
    {
        [Display(Name = "Nome", Description = "Nome Cadastro de Categoria")]
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Name { get; set; }
        [Display(Name = "Ativo", Description = "Situação de Cadastro")]
        public bool Ativo { get; set; }
    }
}
