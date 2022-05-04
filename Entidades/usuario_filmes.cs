using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaRelacionamento.Entidades
{
    public class usuario_filmes
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int FilmeId { get; set; }
        public Filme filme { get; set; }
        public Usuario usuario{ get; set; }

    }
}
