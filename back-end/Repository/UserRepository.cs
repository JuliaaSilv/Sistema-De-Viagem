using System.Threading.Tasks;
using agencia.Models;
using agencia.Data;
using Microsoft.EntityFrameworkCore;

namespace agencia.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CpfExistsAsync(string cpf)
        {
            return await _context.Usuarios.AnyAsync(u => u.Cpf == cpf);
        }

        public async Task<Usuario> AddAsync(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }
    }
}
