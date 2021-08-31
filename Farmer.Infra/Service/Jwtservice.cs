using Farmer.Core.Data;
using Farmer.Core.Repository;
using Farmer.Core.Service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Farmer.Infra.Service
{
   public class Jwtservice : IJwtservice
    {
        private readonly Ijwtrepo ijwtrepo;
        public Jwtservice(Ijwtrepo ijwtrepo)
        {
            this.ijwtrepo = ijwtrepo;

        }
        public string Authencate(login login)
        {
            var acc = ijwtrepo.login1(login);

            if (acc == null)
            {
                return null;
            }


            var tokenhandler = new JwtSecurityTokenHandler();
            var tokenkey = Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]");
            var tokendesciptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {

                 new Claim(ClaimTypes.Name, acc.username),
                    new Claim(ClaimTypes.Role,acc.rolename),

                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenkey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenhandler.CreateToken(tokendesciptor);
            return tokenhandler.WriteToken(token);


        }
    }
}
