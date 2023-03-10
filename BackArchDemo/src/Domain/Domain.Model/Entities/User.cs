namespace Domain.Model.Entities
{
    /// <summary>
    /// User
    /// </summary>
    public class User
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id {get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Appelido
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
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="correo"></param>
        /// <param name="ciudadania"></param>
        /// <param name="ocupacion"></param>
        public User(string id, string nombre, string apellido, int edad, string correo, string ciudadania,
            string ocupacion)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Correo = correo;
            Ciudadania = ciudadania;
            Ocupacion = ocupacion;
        }

        /// <summary>
        /// Añadir correo
        /// </summary>
        /// <param name="correo"></param>
        public string AñadirCorreo(string correo) => Correo = correo;
    }
}