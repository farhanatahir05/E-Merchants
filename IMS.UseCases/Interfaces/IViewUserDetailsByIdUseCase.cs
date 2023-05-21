using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IViewUserDetailsByIdUseCase
    {
        Task<UserDetails> ExecuteAsync(string userId);
    }
}