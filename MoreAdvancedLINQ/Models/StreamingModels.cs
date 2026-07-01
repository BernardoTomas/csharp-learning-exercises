using System.Runtime.CompilerServices;

namespace Streaming.Models;

public class Media : IMedia
{
    public string Name { get; set; }
    public int GenreId { get; set; }
    public float Rating { get; set; }

    public Media (string name, int genreId, float rating)
    {
        Name = name;
        GenreId = genreId;
        Rating = rating;
    }
}

public class Movie : Media, IMovie
{
    public TimeSpan Duration { get; set; }

    public Movie (string name, int genreId, float rating, TimeSpan duration) : base(name, genreId, rating)
    {
        Duration = duration;
    }
}

public class TvShow : Media, ITvShow
{
    public int Seasons { get; set; }
    public int TotalEpisodes { get; set; }
    public TvShow (string name, int genreId, float rating, int seasons, int episodesCount) : base(name, genreId, rating)
    {
        Seasons = seasons;
        TotalEpisodes = episodesCount;
    }
}