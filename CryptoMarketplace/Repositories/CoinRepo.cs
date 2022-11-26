using CryptoMarketplace.Models;
using CryptoMarketplace.Repositories.Helpers;
using CryptoMarketplace.Repositories.Interfaces;
using X.PagedList;

namespace CryptoMarketplace.Repositories
{
    public class CoinRepo : ICoinRepo
    {
        private HelperMethods _helpers;

        public CoinRepo(HelperMethods helpers)
        {
            _helpers = helpers;
        }

        public IPagedList<Coin> GetAllCoinsFiltered(string? symbol = null)
        {
            var coins = _helpers.GetAllCoins().Result;

            if (!String.IsNullOrWhiteSpace(symbol))
            {
                coins = coins.Where(sy => sy.Symbol.Trim().ToLower().Contains(symbol.Trim().ToLower())).ToList();
            }

            return coins.ToPagedList();
        }
    }
}
