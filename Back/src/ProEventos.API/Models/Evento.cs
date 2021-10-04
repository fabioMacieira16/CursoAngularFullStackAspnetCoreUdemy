using System;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.API.Models
{
    public class Evento
    {
        [Key]
        public int EnventoId { get; set; }
        public String Local { get; set; }
        public string DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string Lote { get; set; }
        public string ImagemURL { get; set; }

    }
}