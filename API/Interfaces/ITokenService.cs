using System;
using API.Entities;

namespace API.Interfaces;

public interface ITokenService //abstract is away from implementation
{
    string CreateToken(AppUser user);
}
