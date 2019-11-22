using Common.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleApp.Interfaces
{
    /// <summary>
    /// This interface uses Refit to set the requests to the Web API for Authentication
    /// </summary>
    public interface ILoginApiService
    {
        /// <summary>
        /// API for authentication that will return a Token to be registered and used for further requests to the Web API
        /// </summary>
        /// <param name="login"></param>
        /// <returns>Token</returns>
        [Post("/api/mock/token")]
        Task<string> GetToken([Body(BodySerializationMethod.UrlEncoded)] Login login);



    }
}
