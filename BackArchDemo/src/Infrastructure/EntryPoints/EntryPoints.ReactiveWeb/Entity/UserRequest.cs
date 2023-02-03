using Domain.Model.Entities;

namespace EntryPoints.ReactiveWeb.Entity;

/// <summary>
/// UserRequest
/// </summary>
public class UserRequest
{
    /// <summary>
    /// Id
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Name
    /// </summary>
    public string Nombre { get; set; }

    /// <summary>
    /// Apellido
    /// </summary>
    public string Apellido { get; set; }

    /// <summary>
    /// Edad
    /// </summary>
    public int Edad { get; set; }

    /// <summary>
    /// Correo
    /// </summary>
    public string Correo { get; set; }

    /// <summary>
    /// Ciudadanía
    /// </summary>
    public string Ciudadania { get; set; }

    /// <summary>
    /// Ocupacion
    /// </summary>
    public string Ocupacion { get; set; }

    /// <summary>
    /// AsEntity
    /// </summary>
    /// <returns></returns>
    public User AsEntity() => new(Id, Nombre, Apellido, Edad, Correo, Ciudadania, Ocupacion);
}