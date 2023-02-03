using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Model.Entities;
using Domain.UseCase.Common;
using Domain.UseCase.User;
using EntryPoints.ReactiveWeb.Base;
using EntryPoints.ReactiveWeb.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EntryPoints.ReactiveWeb.Controllers
{
    /// <summary>
    /// UserController
    /// </summary>
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("api/[controller]/[action]")]
    public class UserController : AppControllerBase<UserController>
    {
        private readonly IUserUseCase _userUseCase;
        private readonly IManageEventsUseCase testNegocio;
        private readonly ILogger<UserController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// </summary>
        /// <param name="testNegocio"></param>
        /// <param name="logger"></param>
        /// <param name="userUseCase"></param>
        public UserController(IManageEventsUseCase testNegocio, ILogger<UserController> logger,
            IUserUseCase userUseCase) :
            base(testNegocio)
        {
            _logger = logger;

            _userUseCase = userUseCase;
            this.testNegocio = testNegocio;
        }

        /// <summary>
        /// Obtiene todos los objetos de tipo <see cref="User"/>
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        public async Task<IActionResult> ObtenerUsuarios()
        {
            _logger.LogInformation("Entro al controlador en: {time}", DateTimeOffset.Now);
            return await HandleRequest(async () => await _userUseCase.ObtenerTodosLosUsuarios(), "");
        }

        /// <summary>
        /// ObtenerUsuarioPorId
        /// </summary>
        /// <returns></returns>
        [HttpGet("id")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        public async Task<IActionResult> ObtenerUsuarioPorId([FromQuery] string id)
        {
            return await HandleRequest(async () => await _userUseCase.ObtenerUsuarioPorId(id), "");
        }

        /// <summary>
        /// CrearUsuario
        /// </summary>
        /// <param name="userRequest"></param>
        /// <returns></returns>
        [HttpPost()]
        [ProducesResponseType(201, Type = typeof(IEnumerable<User>))]
        public async Task<IActionResult> CrearUsuario([FromBody] UserRequest userRequest)
        {
            return await HandleRequest(async () =>
            {
                var user = userRequest.AsEntity();
                return await _userUseCase.CrearUsuario(user, userRequest.Correo);
            }, "");
        }

        /// <summary>
        /// ActualizarUsuario
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userRequest"></param>
        /// <returns></returns>
        [HttpPut("id")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        public async Task<IActionResult> ActualizarUsuario([FromQuery] string id, [FromBody] UserRequest userRequest)
        {
            return await HandleRequest(async () =>
            {
                var user = userRequest.AsEntity();
                await _userUseCase.ActualizarUsuarioPorId(id, user);
                return UserResponse.Exec(id, user);
            }, "");
        }

        /// <summary>
        /// EliminarUsuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("id")]
        [ProducesResponseType(400, Type = typeof(IEnumerable<User>))]
        public async Task<IActionResult> EliminarUsuario([FromQuery] string id)
        {
            return await HandleRequest(async () =>
            {
                await _userUseCase.EliminarUsuarioPorId(id);
                return NoContent();
            }, "");
        }
    }
}