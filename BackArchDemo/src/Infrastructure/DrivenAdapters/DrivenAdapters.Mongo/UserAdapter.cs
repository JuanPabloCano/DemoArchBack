using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Model.Entities;
using Domain.Model.Entities.Gateway;
using DrivenAdapters.Mongo.Entities;
using MongoDB.Driver;

namespace DrivenAdapters.Mongo
{
    /// <summary>
    /// UserDataAdapter
    /// </summary>
    public class UserAdapter : IUserEntityRepository
    {
        private readonly IMongoCollection<UserData> _userCollection;

        /// <summary>
        /// Constuctor
        /// </summary>
        /// <param name="mongodb"></param>
        public UserAdapter(IContext mongodb)
        {
            _userCollection = mongodb.User;
        }

        /// <summary>
        /// ObtenerTodosLosUsuariosAsync
        /// </summary>
        /// <returns></returns>
        public async Task<List<User>> ObtenerTodosLosUsuariosAsync()
        {
            var userData = await _userCollection.FindAsync(Builders<UserData>.Filter.Empty);
            return userData.ToEnumerable().Select(userdata => userdata.AsEntity()).ToList();
        }

        /// <summary>
        /// ObtenerUsuarioPorIdAsync
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<User> ObtenerUsuarioPorIdAsync(string id)
        {
            var user = await _userCollection.FindAsync(user => user.Id == id);
            return user.FirstAsync().Result.AsEntity();
        }

        /// <summary>
        /// CrearUsuarioAsync
        /// </summary>
        /// <param name="user"></param>
        /// <param name="correo"></param>
        /// <returns></returns>
        public async Task<User> CrearUsuarioAsync(User user, string correo)
        {
            UserData userData = new(user.Nombre, user.Apellido, user.Edad, user.AñadirCorreo(correo),
                user.Ciudadania, user.Ocupacion);
            await _userCollection.InsertOneAsync(userData);
            return userData.AsEntity();
        }

        /// <summary>
        /// ActualizarUsuarioPorIdAsync
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        public async Task ActualizarUsuarioPorIdAsync(string id, User user)
        {
            UserData userData = new(user.Nombre, user.Apellido, user.Edad, user.Correo, user.Ciudadania,
                user.Ocupacion);
            await _userCollection.FindOneAndReplaceAsync(selectedUser => selectedUser.Id == id, userData);
        }

        /// <summary>
        /// EliminarUsuarioPorIdAsync
        /// </summary>
        /// <param name="id"></param>
        public async Task EliminarUsuarioPorIdAsync(string id) =>
            await _userCollection.FindOneAndDeleteAsync(user => user.Id == id);
    }
}