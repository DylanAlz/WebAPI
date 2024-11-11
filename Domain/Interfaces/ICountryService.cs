using WebAPI.DAL.Entities;

namespace WebAPI.Domain.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetCountriesAsync();
        Task<Country> GetCountryByIdAsync(Guid id);
        Task<Country> CreateCountryAsync(Country country);
        Task<Country> DeleteCountryAsync(Guid Id);
        Task<Country> EditCountryAsync(Country country);             
    }
}
