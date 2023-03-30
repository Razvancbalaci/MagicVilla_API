using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web.Services.IServices
{
    public interface IVillaService
    {
        Task<T> GetAll<T>(string token);
        Task<T> Get<T>(int id, string token);
        Task<T> Create<T>(VillaCreateDTO dto, string token);  
        Task<T> Update<T>(VillaUpdateDTO dto, string token);
        Task<T> Delete<T>(int id, string token);
    }
}
