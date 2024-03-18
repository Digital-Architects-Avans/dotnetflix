using dotnetflix.Api.Data;
using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Subscriber;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Repositories.Subscribers;

public class SubscribersRepository : ISubscribersRepository
{
    private readonly DotNetFlixDbContext _dotNetFlixDbContext;

    public SubscribersRepository(DotNetFlixDbContext dotNetFlixDbContext)
    {
        _dotNetFlixDbContext = dotNetFlixDbContext;
    }

    public async Task<IEnumerable<Subscriber>> GetSubscribers()
    {
        var subscribers = await _dotNetFlixDbContext.Subscribers.ToListAsync();
        return subscribers;
    }

    public async Task<Subscriber> AddSubscriber(AddSubscriberDto addSubscriberDto)
    {
        var subscriber = new Subscriber
        {
            Name = addSubscriberDto.Name,
            Email = addSubscriberDto.Email
        };

        var result = await _dotNetFlixDbContext.Subscribers.AddAsync(subscriber);
        await _dotNetFlixDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<bool> DeleteSubscriber(int id)
    {
        var subscriber = await _dotNetFlixDbContext.Subscribers.FindAsync(id);

        if (subscriber == null)
            return false;
        
        _dotNetFlixDbContext.Subscribers.Remove(subscriber);
        await _dotNetFlixDbContext.SaveChangesAsync();

        return true;
    }
}

