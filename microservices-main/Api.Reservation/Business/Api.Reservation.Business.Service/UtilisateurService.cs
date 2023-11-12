
using Api.Reservation.Datas.Entities;
using Api.Reservation.Datas.Repository;

namespace Api.Reservation.Business.Service
{
    public class UtilisateurService : IUtilisateurService
    {
        private readonly IUtilisateurRepository _utilisateurRepository;

        public async Task<Utilisateur> CreateUserAsync(Utilisateur user)
        {
            return await _utilisateurRepository.CreateUserAsync(user)
                .ConfigureAwait(false);
        }

        public async Task<Datas.Entities.Utilisateur> GetUserByIdAsync(int id)
        {
            return await _utilisateurRepository.GetUserByIdAsync(id)
               .ConfigureAwait(false);
        }
    }
}
