using dotnetflix.Models.Dtos.Subscriber;

namespace dotnetflix.Web.Services.Contracts
{
    public interface ISubscriberService
    {
        Task<IEnumerable<SubscriberDto>?> GetSubscribers();
        Task<bool> AddSubscriber(AddSubscriberDto addSubscriberDto);

        Task<bool> DeleteSubscriber(int id);
    }
}
