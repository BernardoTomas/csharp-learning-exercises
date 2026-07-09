namespace Streaming.Models;

public interface IMedia
{
    string Name { get; set; }
    int Id { get; set; }
}

public interface IGenredMedia : IMedia
{
    MediaGenres[] GenreIds { get; set; }
}
public interface IMovie : IGenredMedia
{
    TimeSpan Duration { get; set; }
}

public interface ITvShow : IGenredMedia
{
    string TvShowRefID { get; set; }
}


public interface IEpisode : IMedia
{
    string TvShowRefID { get; set; }
    int Season { get; set; }
    int EpNumber { get; set; }
    TimeSpan Duration { get; set; }
}

