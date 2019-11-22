using SampleApp.Infra;
using SampleApp.Interfaces;
using Common.Models;
using Refit;
using System;
using System.Configuration;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var urlBase = ConfigurationManager.AppSettings["URLBASE"]; 
            var user = ConfigurationManager.AppSettings["USER"];
            var pass = ConfigurationManager.AppSettings["PASS"];

            SetGlobalExceptionHandler();

            var apiService = LoginAndRegisterAccessToken(user, pass, urlBase);

            GetCutomersFromWebApi(apiService);

            SaveCustomerToWebApi(apiService);

            Console.ReadLine();

        }

        static void GetCutomersFromWebApi(IApiService apiService)
        {
            var customers = apiService.GetCustomersAsync().Result;

            customers.ToList().ForEach(c => Console.WriteLine(c.ToString()));
        }

        static void SaveCustomerToWebApi(IApiService apiService)
        {
            var newCustomer = new Customer { Id = Guid.NewGuid(), Name = "Customer Test", Birthday = DateTime.Now.AddYears(-38) };

            var result = apiService.SaveCustomerAsync(newCustomer).Result;
            
            Console.WriteLine($"Save new Customer result: {(result.Success ? "Success" : "Error")} - {result.Message}");
        }

        static IApiService LoginAndRegisterAccessToken(string user, string password, string urlBase)
        {
            var loginApiService = RestService.For<ILoginApiService>(urlBase);
            string token = loginApiService.GetToken(
                new Login()
                {
                    username = user,
                    password = password
                }
            ).Result;

            Token tokenModel = JsonConvert.DeserializeObject<Token>(token);

            return RestService.For<IApiService>(urlBase,
                new RefitSettings
                {
                    AuthorizationHeaderValueGetter = () => Task.FromResult(tokenModel.AccessToken)
                });
        }

        static void SetGlobalExceptionHandler()
        {
            AppDomain appDomain = AppDomain.CurrentDomain;
            appDomain.UnhandledException += (sender, args) => Logger.SaveLog((Exception)args.ExceptionObject);
        }


    }
}
