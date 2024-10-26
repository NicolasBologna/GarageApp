using Common.DTOs.English;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GarageApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _config;

        public LoginController(IUserService userService, IConfiguration config)
        {
            _userService = userService;
            _config = config;
        }
        [HttpPost]
        public IActionResult Login(LoginReqDto loginData)
        {

            if (loginData.UserName == null || loginData.UserName == "")//es lo mismo que: if(string.IsNullOrEmpty(loginData.UserName))
            {
                return BadRequest("Debe ingresar un nombre de usuario.");
            }
            if (loginData.Password == null || loginData.Password == "")//es lo mismo que: if(string.IsNullOrEmpty(loginData.Password))
            {
                return BadRequest("Debe ingresar una contraseña.");
            }
            var user = _userService.ValidateUser(loginData);

            if (user != null)
            {
                //Paso 2: Crear el token
                var securityPassword = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_config["Authentication:SecretForKey"])); //Traemos la SecretKey del Json. agregar antes: using Microsoft.IdentityModel.Tokens;

                var credentials = new SigningCredentials(securityPassword, SecurityAlgorithms.HmacSha256);

                //Los claims son datos en clave->valor que nos permite guardar data del usuario.
                var claimsForToken = new List<Claim>();
                claimsForToken.Add(new Claim("sub", user.Id.ToString())); //"sub" es una key estándar que significa unique user identifier, es decir, si mandamos el id del usuario por convención lo hacemos con la key "sub".
                claimsForToken.Add(new Claim("given_name", user.Name)); //Lo mismo para given_name y family_name, son las convenciones para nombre y apellido. Ustedes pueden usar lo que quieran, pero si alguien que no conoce la app

                var jwtSecurityToken = new JwtSecurityToken( //agregar using System.IdentityModel.Tokens.Jwt; Acá es donde se crea el token con toda la data que le pasamos antes.
                  _config["Authentication:Issuer"],
                  _config["Authentication:Audience"],
                  claimsForToken,
                  DateTime.UtcNow,
                  DateTime.UtcNow.AddHours(1),
                  credentials);

                var tokenToReturn = new JwtSecurityTokenHandler() //Pasamos el token a string
                    .WriteToken(jwtSecurityToken);

                LoginRspDto loginRspDto = new LoginRspDto();
                loginRspDto.Mensaje = "El usuario se autenticó correctamente";
                loginRspDto.Status = 200;
                loginRspDto.Token = tokenToReturn;

                return Ok(loginRspDto);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
