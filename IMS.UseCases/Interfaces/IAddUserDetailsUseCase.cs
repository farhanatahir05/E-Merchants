using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IAddUserDetailsUseCase
    {
        Task ExecuteAsync(string name, string address, string contact, string userId);
    }
}