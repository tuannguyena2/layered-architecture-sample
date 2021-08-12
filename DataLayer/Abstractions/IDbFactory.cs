using System;

namespace DataLayer.Abstractions
{
    public interface IDbFactory : IDisposable
    {
        SADPContext Get();
    }
}
