using Domain.Model.Entities;

namespace EntryPoints.ReactiveWeb.Entity;

/// <summary>
/// UserRequest
/// </summary>
public class UserRequest
{
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

    public User AsEntity() => new(Nombre, Apellido, Edad, Ciudadania, Ocupacion);
}