using System;
using XGame.Domain.ValueObject;

namespace XGame.Domain.Interace.Services
{
    public interface IservicePlayer
    {
        string  AutenticarPlayer(string Email, string senha);

       Guid AdicionarPlayer(Nome nome, Email email, string senha);

    }
}
