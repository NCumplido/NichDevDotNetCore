using NichDevDotNetCore.Models;

namespace NichDevDotNetCore.Services
{
    public class FakeCatFactService : ICatFactService
    {
        public async Task<CatFact> GetCatFact()
        {
            return new CatFact
            {
                Fact = "Fake cat fact",
                Length = 20
            };
        }
    }
}
