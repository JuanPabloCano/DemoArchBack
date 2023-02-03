using Domain.Model.Entities;

namespace EntryPoints.ReactiveWeb.Entity;

/// <summary>
/// UserResponse
/// </summary>
public abstract class UserResponse
{
    /// <summary>
    /// Exec method
    /// </summary>
    /// <param name="id"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    public static object Exec(string id, User user)
    {
        return new
        {
            Id = id,
            user.Nombre,
            user.Apellido,
            user.Edad,
            user.Correo,
            user.Ciudadania,
            user.Ocupacion
        };
    }
}