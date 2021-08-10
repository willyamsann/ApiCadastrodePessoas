using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCadastrodePessoas.Models
{
    public class Pessoa
    {
        [Key]
        public new int Id { get; set; }

        public string Name { get; set; }

        public int Idade { get; set; }

    }
}
