using System;
using System.Threading.Tasks;
using DonatonBlazor.Interfaces;

namespace DonatonBlazor.Services
{
    public class HttpService : IHttpService
    {
        public Task<string> DeleteAsync(Uri uri)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync<T>(Uri uri)
        {
            throw new NotImplementedException();
        }

        public Task<T> PatchAsync<T>(Uri uri, T content)
        {
            throw new NotImplementedException();
        }

        public Task<T> PostAsync<T>(Uri uri, T content)
        {
            throw new NotImplementedException();
        }

        public Task<T> PutAsync<T>(Uri uri, T content)
        {
            throw new NotImplementedException();
        }
    }
}