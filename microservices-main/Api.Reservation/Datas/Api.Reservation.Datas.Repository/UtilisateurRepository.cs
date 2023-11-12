using Api.Reservation.Datas.Context;
using Api.Reservation.Datas.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Api.Reservation.Datas.Repository
{
    public class UtilisateurRepository : IUtilisateurRepository
    {
        private readonly IApplicationDbContext _context;

        public UtilisateurRepository(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Utilisateur> GetUserByIdAsync(int id)
        {
            return await _context.Utilisateur.Include(u => u.Id)
                .FirstOrDefaultAsync(u => u.Id == id)
                .ConfigureAwait(false);
        }

        public async Task<Utilisateur> CreateUserAsync(Utilisateur user)
        {
            await _context.Utilisateur.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task UpdateUser(Utilisateur user)
        {
            _context.Utilisateur.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await _context.Utilisateur.FindAsync(id);
            if (user != null)
            {
                _context.Utilisateur.Remove(user);
                await _context.SaveChangesAsync();
            }
        }
    }
}
