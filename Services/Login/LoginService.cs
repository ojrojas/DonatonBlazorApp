using System;
using System.Threading.Tasks;
using DonatonBlazor.Configuration;
using DonatonBlazor.Interfaces;
using DonatonBlazor.Models;
using Microsoft.Extensions.Options;

namespace DonatonBlazor.Services
{
    public class LoginService : ILoginService
    {
        private readonly IHttpService httpClient;
        private readonly ILoginService loginService;
        IOptions<DonatonConfiguration> configuration;

        public LoginService(IHttpService httpClient, ILoginService loginService, IOptions<DonatonConfiguration> configuration)
        {
            this.httpClient = httpClient;
            this.loginService = loginService;
            this.configuration = configuration;
        }

        public async Task<string> Login(ILoginModel model)
        {
            var user = await httpClient.PostAsync(new Uri($"{configuration.Value}login"), model);
            return string.Empty;
        }
    }
}