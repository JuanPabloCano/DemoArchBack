using AutoMapper;
using Domain.Model.Entities;

namespace BackArchDemo.AppServices.Automapper
{
    /// <summary>
    /// EntityProfile
    /// </summary>
    public class ConfigurationProfile : Profile
    {
        /// <summary>
        /// ConfigurationProfile
        /// </summary>
        public ConfigurationProfile()
        {
            CreateMap<User, DrivenAdapters.Mongo.Entities.UserData>();
            CreateMap<DrivenAdapters.Mongo.Entities.UserData, User>();
        }
    }
}