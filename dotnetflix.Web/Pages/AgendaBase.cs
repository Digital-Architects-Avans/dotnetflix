using dotnetflix.Models.Dtos.Show;
using dotnetflix.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using System.Linq;

namespace dotnetflix.Web.Pages;

public class AgendaBase : ComponentBase
{
    [Inject]
    public IShowService ShowService { get; set; }
    public IEnumerable<ShowDto> Shows { get; set; }
    public IQueryable<MovieWithDates> MoviesWithDates { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Shows = await ShowService.GetShows();
        await GetShowByDay(DateTime.Now);
    }

    protected Task GetShowByDay(DateTime date)
    {
        if (Shows != null)
        {
            var groupedShows = Shows.GroupBy(s => s.MovieId);

            var moviesWithDatesList = new List<MovieWithDates>();

            foreach (var group in groupedShows)
            {
                ShowDto show = group.First();

                MovieWithDates movieWithDates = new MovieWithDates
                {
                    MovieId = show.MovieId,
                    MovieTitle = show.MovieTitle,
                    Dates = group.Select(s => s.Date).Where(d => d.ToString("yyyy-MM-dd") == date.ToString("yyyy-MM-dd")).ToList()
                };

                moviesWithDatesList.Add(movieWithDates);
            }

            MoviesWithDates = moviesWithDatesList.AsQueryable();
        }
        StateHasChanged();
        return Task.CompletedTask;
    }

    public class MovieWithDates
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public List<DateTime> Dates { get; set; }
    }
}

