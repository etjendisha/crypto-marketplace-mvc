using CryptoMarketplace.Models;
using Newtonsoft.Json;
using X.PagedList;

namespace CryptoMarketplace.Repositories.Helpers
{
    public class HelperMethods
    {
        public async Task<List<Coin>> GetAllCoins()
        {
            var coinList = new List<Coin>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://api2.binance.com/api/v3/ticker/24hr"))
                {
                    string result = await response.Content.ReadAsStringAsync();
                    coinList = JsonConvert.DeserializeObject<List<Coin>>(result);
                }
            }
            return coinList;
        }
    }
}
