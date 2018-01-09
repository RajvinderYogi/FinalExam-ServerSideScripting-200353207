using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2084FinalF2017.Models
{
    public interface InterfaceCountries
    {
        IQueryable<Country> Countries { get; }

        Country Save(Country country);
        void Delete(Country country);
    }
}
