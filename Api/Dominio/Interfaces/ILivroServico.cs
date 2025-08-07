using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ControleBibliotecaApi.Dominio.DTOs;
using ControleBibliotecaApi.Dominio.Entidades;

namespace ControleBibliotecaApi.Dominio.Interfaces
{
    public interface ILivroServico
    {
        Task<List<Livro>> ListarAsync();
        Task<Livro> AdicionarAsync(LivroDTO dto);
    }
}
