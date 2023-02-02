using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.UseCase.User;

/// <summary>
/// IUser UseCase
/// </summary>
public interface IUserUseCase
{
    /// <summary>
    /// ObtenerTodosLosUsuarios
    /// </summary>
    /// <returns></returns>
    Task<List<Model.Entities.User>> ObtenerTodosLosUsuarios();

    /// <summary>
    /// ObtenerUsuarioPorId
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<Model.Entities.User> ObtenerUsuarioPorId(string id);

    /// <summary>
    /// CrearUsuario
    /// </summary>
    /// <param name="user"></param>
    /// <param name="correo"></param>
    /// <returns></returns>
    Task<Model.Entities.User> CrearUsuario(Model.Entities.User user, string correo);

    /// <summary>
    /// ActualizarUsuarioPorId
    /// </summary>
    /// <param name="id"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    Task ActualizarUsuarioPorId(string id, Model.Entities.User user);

    /// <summary>
    /// EliminarUsuarioPorId
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task EliminarUsuarioPorId(string id);
}