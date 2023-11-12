using Api.Reservation.Datas.Entities;

namespace Api.Reservation.Datas.Repository
{
    public interface IUtilisateurRepository
    {

        Task<Entities.Utilisateur> GetUserByIdAsync(int id);

        Task<Utilisateur> CreateUserAsync(Utilisateur user);
    }
}
