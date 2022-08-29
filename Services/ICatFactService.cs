using NichDevDotNetCore.Models;

namespace NichDevDotNetCore.Services
{
    public interface ICatFactService
    {
        Task<CatFact> GetCatFact();
    }
}
