using agencia.Models;
namespace agencia.Repository
{
    public interface IUserRepository
    {
        Task<bool> CpfExistsAsync(string cpf);
        Task<Usuario> AddAsync(Usuario usuario);
    }
}