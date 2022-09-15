using Edsm.Sdk.Dto;

namespace Edsm.Sdk
{
    public interface IEdsmClient
    {
        Task<T?> SendRequest<T>(IEdsmRequest request) where T : IEdsmResponse;
    }
}