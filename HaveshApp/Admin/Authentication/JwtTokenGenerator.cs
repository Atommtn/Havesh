namespace ShokouhApp.Admin.Authentication;

using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public class JwtTokenGenerator
{
    private readonly string _secretKey;
    private readonly string _issuer;
    private readonly string _audience;
    private readonly int _expiryMinutes;
    readonly IConfiguration _configuration;

    public JwtTokenGenerator(string secretKey, string issuer, string audience, int expiryMinutes)
    {
        _secretKey = secretKey;
        _issuer = issuer;
        _audience = audience;
        _expiryMinutes = expiryMinutes;

    }

    /// <exception cref="ArgumentNullException">if 'algorithm' is null or empty.</exception>
    /// <exception cref="ArgumentException">If 'expires' &lt;= 'notbefore'.</exception>
    public string GenerateToken(
        string userName,
        IEnumerable<string> roles,
        bool? gender = null,
        string? firstName = null,
        string? lastName = null,
        string? email = null,
        string? mobileNumber = null)
    {
        var claims = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();
        claims.Add(new Claim(ClaimTypes.NameIdentifier, userName));
        if (gender != null) claims.Add(new Claim(ClaimTypes.Gender, gender is true ? "آقای" : "خانم"));
        if (firstName != null) claims.Add(new Claim(ClaimTypes.Name, firstName));
        if (lastName != null) claims.Add(new Claim(ClaimTypes.Surname, lastName));
        if (email != null) claims.Add(new Claim(ClaimTypes.Email, email));
        if (mobileNumber != null) claims.Add(new Claim(ClaimTypes.MobilePhone, mobileNumber));


        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            _issuer,
            _audience,
            claims,
            expires: DateTime.UtcNow.AddMinutes(_expiryMinutes),
            signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
