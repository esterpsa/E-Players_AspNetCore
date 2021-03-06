using System.Collections.Generic;
using E_players_AspNetCore.Models;

namespace E_players_AspNetCore.Interfaces
{
    public interface IEquipe
    {
        //Métodos de Crud
         void Create(Equipe e);

         List<Equipe> ReadAll();

         void Update(Equipe e);

         void Delete(int id);
    }
}