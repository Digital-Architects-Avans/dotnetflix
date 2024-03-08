using dotnetflix.Web.Services.Contracts;

namespace dotnetflix.Web.Services;

public class OrderOptionsService : IOrderOptionsService
{
    public bool PopcornArrangement { get; set; }
    public bool DotNetflixAndChillArrangement { get; set; }
    public bool MAndMsArrangement { get; set; }
}