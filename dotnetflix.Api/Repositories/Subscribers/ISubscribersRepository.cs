using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Subscriber;

namespace dotnetflix.Api.Repositories.Subscribers;

public interface ISubscribersRepository
{
    Task<IEnumerable<Subscriber>> GetSubscribers();
    Task<Subscriber> AddSubscriber(AddSubscriberDto addSubscriberDto);
    Task<bool> DeleteSubscriber(int Id);
}

