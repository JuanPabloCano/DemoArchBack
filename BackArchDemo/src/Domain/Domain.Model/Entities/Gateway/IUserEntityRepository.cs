using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Model.Entities.Gateway
{
    /// <summary>
    /// ITestEntityRepository
    /// </summary>
    public interface IUserEntityRepository
    {
        /// <summary>
        /// FindAll
        /// </summary>
        /// <returns>Entity list</returns>
        Task<List<User>> ObtenerTodosLosUsuariosAsync();

        /// <summary>
        /// ObtenerUsuarioPorId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<User> ObtenerUsuarioPorIdAsync(string id);

        /// <summary>
        /// Crear usuario
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<User> CrearUsuarioAsync(User user, string correo);

        /// <summary>
        /// ActualizarUsuarioPorId
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        Task ActualizarUsuarioPorIdAsync(string id, User user);

        /// <summary>
        /// EliminarUsuarioPorId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task EliminarUsuarioPorIdAsync(string id);
    }
}