﻿using System;
using XGame.Domain.Enum;
using XGame.Domain.ValueObject;

namespace XGame.Domain.Entities
{
     public class Jogador
    {
        public Guid Id { get; set; }

        public Nome Nome { get; set; }

        public Email Email{ get; set; }

        public string Senha{ get; set; }

        public EnumStatusPlayer Status { get; set; }

    }

}
