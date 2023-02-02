using Domain.Model.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DrivenAdapters.Mongo.Entities
{
    /// <summary>
    /// UserData
    /// </summary>
    public class UserData
    {
        /// <summary>
        /// Id
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [BsonElement(elementName: "nombre")]
        public string Nombre { get; set; }

        /// <summary>
        /// Appelido
        /// </summary>
        [BsonElement(elementName: "apellido")]
        public string Apellido { get; set; }

        /// <summary>
        /// Edad
        /// </summary>
        [BsonElement(elementName: "edad")]
        public int Edad { get; set; }

        /// <summary>
        /// Correo
        /// </summary>
        [BsonElement(elementName: "correo")]
        public string Correo { get; set; }

        /// <summary>
        /// Ciudadanía
        /// </summary>
        [BsonElement(elementName: "ciudadanía")]
        public string Ciudadania { get; set; }

        /// <summary>
        /// Ocupacion
        /// </summary>
        [BsonElement(elementName: "ocupacion")]
        public string Ocupacion { get; set; }

        /// <summary>
        /// AsEntity
        /// </summary>
        /// <returns></returns>
        public User AsEntity() => new(Id, Nombre, Apellido, Edad, Correo, Ciudadania, Ocupacion);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="correo"></param>
        /// <param name="ciudadania"></param>
        /// <param name="ocupacion"></param>
        public UserData(string nombre, string apellido, int edad, string correo, string ciudadania,
            string ocupacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Correo = correo;
            Ciudadania = ciudadania;
            Ocupacion = ocupacion;
        }
    }
}