using Models.DTO;
using Models.Enum;

namespace DAL.Interfaces
{
    public interface ICountryManager
    {
        CountryDto GetCountryByCode(Countries countryCode);

        CountryDto GetCountryByCulture(string culture);
    }
}
