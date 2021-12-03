using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARC.Domain
{
    [Table("Cliente")]
    public class Client
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage=" *Campo obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres")]
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }

    }
}
