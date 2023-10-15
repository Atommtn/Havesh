namespace HaveshApp.Admin.Authentication;

using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public class JwtTokenParser
{
    private readonly string _secretKey;

    public JwtTokenParser(string secretKey)
    {
        _secretKey = secretKey;
    }

    public bool TryParseToken(string? token, out Payload? payload,out ClaimsPrincipal? claimsPrincipal)
    {
        payload = null;
        claimsPrincipal = null;
        if (token.IsNullOrEmpty()) return false;

        var tokenHandler = new JwtSecurityTokenHandler();
        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey)),
            ValidateIssuer = false,
            ValidateAudience = false
        };

        try
        {
            claimsPrincipal = tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);

            payload = new Payload
            {
                UserName = claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier)?.Value,
                Gender = claimsPrincipal.FindFirst(ClaimTypes.Gender)?.Value,
                FirstName = claimsPrincipal.FindFirst(ClaimTypes.Name)?.Value,
                LastName = claimsPrincipal.FindFirst(ClaimTypes.Surname)?.Value,
                Email = claimsPrincipal.FindFirst(ClaimTypes.Email)?.Value,
                Mobile = claimsPrincipal.FindFirst(ClaimTypes.MobilePhone)?.Value,
                Roles = claimsPrincipal.FindAll(ClaimTypes.Role)?.Select(claim => claim.Value).ToList()
            };

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}