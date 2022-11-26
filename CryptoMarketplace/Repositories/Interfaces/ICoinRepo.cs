using CryptoMarketplace.Models;
using X.PagedList;

namespace CryptoMarketplace.Repositories.Interfaces
{
    public interface ICoinRepo
    {
        public IPagedList<Coin> GetAllCoinsFiltered(string? symbol = null);
    }
}
