using System;
using System.Threading.Tasks;

namespace DonatonBlazor.Interfaces
{
    public interface IHttpService
    {
        Task<T> GetAsync<T>(Uri uri);
        Task<T> PostAsync<T>(Uri uri, T content);
        Task<T> PutAsync<T>(Uri uri, T content);
        Task<string> DeleteAsync(Uri uri);
        Task<T> PatchAsync<T>(Uri uri, T content);
    }
}