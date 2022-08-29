using Newtonsoft.Json;
using NichDevDotNetCore.Enums;
using NichDevDotNetCore.Models;
using NichDevDotNetCore.Models.API;
using NichDevDotNetCore.Services;
using System.Net.Http.Headers;

namespace NichDevDotNetCore.API;

public class CatFactService : ICatFactService
{
    public async Task<CatFact> GetCatFact()
    {
        List<CatFact> catFacts = new List<CatFact>();

        var url = $"https://catfact.ninja/fact";

        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(url);
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            var jsonString = await response.Content.ReadAsStringAsync();
            var catFact = JsonConvert.DeserializeObject<CatFact>(jsonString);
            return catFact;
        }
        return null;
    }
}
