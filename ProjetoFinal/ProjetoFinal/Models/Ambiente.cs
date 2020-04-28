﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    public class Ambiente
    {
        [Column("id")]
        [Required]
        [Key]
        public int Id { get; set; }

        [Column("ambiente")]
        [Required]
        [StringLength(100)]
        public string NomeAmbiente { get; set; }
    }
}