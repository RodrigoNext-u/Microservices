using Api.Reservation.Datas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Reservation.Business.Service
{
    public interface IUtilisateurService
    {
        Task<Datas.Entities.Utilisateur> GetUserByIdAsync(int id);

        Task<Utilisateur> CreateUserAsync(Utilisateur user);
    }
}
