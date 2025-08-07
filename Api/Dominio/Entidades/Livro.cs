using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleBibliotecaApi.Dominio.Entidades
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public int Ano { get; set; }
    }
}
