using Domain.Model.Entities;
using DrivenAdapters.Mongo.Entities;
using MongoDB.Driver;

namespace DrivenAdapters.Mongo
{
    /// <summary>
    /// Interfaz Mongo context contract.
    /// </summary>
    public interface IContext
    {
        /// <summary>
        /// Colleccion de UserData
        /// </summary>
        public IMongoCollection<UserData> User { get; }
    }
}