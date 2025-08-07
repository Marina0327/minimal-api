using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ControleBibliotecaApi.Dominio.DTOs
{
    public class LivroDTO
    {
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public int Ano { get; set; }
    }
}
