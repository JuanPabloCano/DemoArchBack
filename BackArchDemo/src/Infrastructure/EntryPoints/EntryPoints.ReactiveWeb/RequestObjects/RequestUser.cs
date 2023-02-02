using DrivenAdapters.Mongo.Entities;

namespace EntryPoints.ReactiveWeb.RequestObjects;

/// <summary>
/// RequestUser
/// </summary>
public class RequestUser
{
    /// <summary>
    /// UserData
    /// </summary>
    public UserData UserData { get; set; }
    
    /// <summary>
    /// Correo
    /// </summary>
    public string Correo { get; set; }
}