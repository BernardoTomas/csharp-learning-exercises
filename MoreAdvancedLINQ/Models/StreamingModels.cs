namespace Streaming.Models;

public class Media : IMedia
{
    public int Id { get; set; }
    public string Name { get; set; }
    public TimeSpan Duration { get; set; } 

    public Media (string name)
    {
        Name = name;
    }
}

public class Movie : Media, IMovie
{
    public new TimeSpan Duration { get; set; }
    public MediaGenres[] GenreIds { get; set; }

    public Movie (string name, MediaGenres[] genreIds, TimeSpan duration) : base(name)
    {
        Duration = duration;
        GenreIds = genreIds;
    }
}

public class TvShow : Media, ITvShow
{
    public string TvShowRefID { get; set; }
    public MediaGenres[] GenreIds { get; set; }
    public TvShow (string name, MediaGenres[] genreIds, string refId) : base(name)
    {
        TvShowRefID = refId;
        GenreIds = genreIds;
    }
}

public class Episode : Media, IEpisode
{
    public string TvShowRefID { get; set; }
    public int Season { get; set; }
    public int EpNumber { get; set; }
    public new TimeSpan Duration { get; set; }

    public Episode (string name, string tvShowRefId, int season, int epNumber, TimeSpan duration) : base(name)
    {
        TvShowRefID = tvShowRefId;
        Season = season;
        EpNumber = epNumber;
        Duration = duration;
    }
}