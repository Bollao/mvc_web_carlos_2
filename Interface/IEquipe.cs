using EJOGOS.Models;
using System.Collections.Generic;

namespace EJOGOS.Controllers.Interface
{
    ///<sumary>
    ///Responsável por determinar quais metodos uma classe terá
    ///é o contrato de classe
    ///</sumary>
    
    public interface IEquipe
    {
        ///CREATE
        ///READALL
        ///UPDATE
        ///DELETE

        void Create(Equipe nova_equipe);
        List<Equipe> ReadAll();

        void Update(Equipe equipe);

        void Delete(int idEquipe);



      
        
    }
}
