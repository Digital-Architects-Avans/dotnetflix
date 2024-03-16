using dotnetflix.Models.Dtos.Subscriber;

namespace dotnetflix.Web.Services.Contracts
{
    public interface ISubscriberService
    {
        Task<IEnumerable<SubscriberService>> GetSubscribers();
        Task<SubscriberDto> AddSubscriber(AddSubscriberDto addSubscriberDto);
    }
}
