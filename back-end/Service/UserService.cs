using agencia.Models;
using agencia.Response;
using agencia.Repository;
using InterfaceService;
using BCrypt.Net;

namespace agencia.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<ApiResponse> RegisterAsync(Usuario usuario)
        {
            // Validação dos campos obrigatórios
            if (string.IsNullOrWhiteSpace(usuario.Nome) ||
                string.IsNullOrWhiteSpace(usuario.Email) ||
                string.IsNullOrWhiteSpace(usuario.Senha) ||
                string.IsNullOrWhiteSpace(usuario.Cpf) ||
                string.IsNullOrWhiteSpace(usuario.Telefone))
            {
                return new ApiResponse(null, new ErrorResponse("Todos os campos obrigatórios devem ser preenchidos."), 400);
            }

            // Verifica duplicidade de CPF
            if (await _repository.CpfExistsAsync(usuario.Cpf))
            {
                return new ApiResponse(null, new ErrorResponse("CPF já cadastrado."), 409);
            }

            // Hash da senha
            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

            var novoUsuario = await _repository.AddAsync(usuario);

            return new ApiResponse(novoUsuario, null, 201);
        }
    }

}