namespace dotnetflix.Web.Services.Contracts;

public interface IOrderOptionsService
{
    bool PopcornArrangement { get; set; }
    bool DotNetflixAndChillArrangement { get; set; }
    bool MAndMsArrangement { get; set; }
}