using System;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup(typeof(WebApiMock.Startup))]

namespace WebApiMock
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            var config = new HttpConfiguration();
            
            // Routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                  name: "DefaultApi",
                  routeTemplate: "api/{controller}/{id}",
                  defaults: new { id = RouteParameter.Optional }
             );
            // cors
            app.UseCors(CorsOptions.AllowAll);

            // Activating Token Generation
            ActivateAccessTokenGeneration(app);

            app.UseWebApi(config);
        }

        private void ActivateAccessTokenGeneration(IAppBuilder app)
        {
            var TokenConfigOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/api/mock/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(1), //Omit this parameter, if no expiration time is intended  
                Provider = new AccessTokenProvider()
            };
            app.UseOAuthAuthorizationServer(TokenConfigOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}
