using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Model.Entities.Gateway;

namespace Domain.UseCase.User;

/// <summary>
/// User UseCase
/// </summary>
public class UserUseCase : IUserUseCase
{
    private readonly IUserEntityRepository _userEntityRepository;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="userEntityRepository"></param>
    public UserUseCase(IUserEntityRepository userEntityRepository)
    {
        _userEntityRepository = userEntityRepository;
    }

    /// <summary>
    /// ObtenerTodosLosUsuarios
    /// <see cref="IUserUseCase.ObtenerTodosLosUsuarios"/>
    /// </summary>
    /// <returns></returns>
    public async Task<List<Model.Entities.User>> ObtenerTodosLosUsuarios()
    {
        return await _userEntityRepository.ObtenerTodosLosUsuariosAsync();
    }

    /// <summary>
    /// ObtenerUsuarioPorId
    /// <see cref="IUserUseCase.ObtenerUsuarioPorId"/>
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<Model.Entities.User> ObtenerUsuarioPorId(string id)
    {
        return await _userEntityRepository.ObtenerUsuarioPorIdAsync(id);
    }

    /// <summary>
    /// CrearUsuario
    /// <see cref="IUserUseCase.CrearUsuario"/>
    /// </summary>
    /// <param name="user"></param>
    /// <param name="correo"></param>
    /// <returns></returns>
    public async Task<Model.Entities.User> CrearUsuario(Model.Entities.User user, string correo)
    {
        return await _userEntityRepository.CrearUsuarioAsync(user, correo);
    }

    /// <summary>
    /// ActualizarUsuarioPorId
    /// <see cref="IUserUseCase.ActualizarUsuarioPorId"/>
    /// </summary>
    /// <param name="id"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    public async Task<Model.Entities.User> ActualizarUsuarioPorId(string id, Model.Entities.User user)
    {
        return await _userEntityRepository.ActualizarUsuarioPorIdAsync(id, user);
    }

    /// <summary>
    /// EliminarUsuarioPorId
    /// <see cref="IUserUseCase.EliminarUsuarioPorId"/>
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task EliminarUsuarioPorId(string id)
    {
        await _userEntityRepository.EliminarUsuarioPorIdAsync(id);
    }
}