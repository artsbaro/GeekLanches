using System.Collections.Generic;
using System.Threading.Tasks;

namespace SIP.Domain.Interfaces.Services
{
    public interface IViaCep
    {
        static async Task<IEnumerable<ViaCEPResult>> SearchAsync(string stateInitials, string city, string address);
    }
}
