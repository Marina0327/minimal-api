using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleBibliotecaApi.Dominio.DTOs;
using ControleBibliotecaApi.Dominio.Entidades;
using ControleBibliotecaApi.Dominio.Interfaces;

namespace ControleBibliotecaApi.Dominio.Servicos
{
    public class LivroServico : ILivroServico
    {
        private readonly List<Livro> _livros = new();
        private int _id = 1;

        public Task<List<Livro>> ListarAsync()
        {
            return Task.FromResult(_livros);
        }

        public Task<Livro> AdicionarAsync(LivroDTO dto)
        {
            var livro = new Livro
            {
                Id = _id++,
                Titulo = dto.Titulo,
                Autor = dto.Autor,
                ISBN = dto.ISBN,
                Ano = dto.Ano
            };
            _livros.Add(livro);
            return Task.FromResult(livro);
        }
    }
}
