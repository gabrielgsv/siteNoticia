using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteNoticia.Models
{
    public class Noticia
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Titulo necessario")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Texto necessario")]
        [DataType(DataType.MultilineText)]
        public string Texto { get; set; }
        public string Fonte { get; set; }
        public string Autor { get; set; }

        public byte[] Imagem { get; set; }

        [Required(ErrorMessage = "Categoria necessario")]
        public string Categoria { get; set; }
    }
}
