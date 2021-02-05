using System;

namespace XGame.Domain.Entities
{
    public class MyJogos
    {
        public Guid Id { get; set; }

        public JogoPlataforma JogoPlataforma { get; set; }

        public bool Deseja { get; set; }

        public bool Troca { get; set; }

        public bool Venda { get; set; }

        public DateTime DataDesejo { get; set; }
    }

}
