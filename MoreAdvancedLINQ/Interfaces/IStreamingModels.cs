namespace Streaming.Models;

public interface IMedia
{
    string Name { get; set; }
    int Id { get; set; }
    float Rating { get; set; }
}

public interface IGenredMedia : IMedia
{
    int[] GenreIds { get; set; }
}
public interface IMovie : IGenredMedia
{
    TimeSpan Duration { get; set; }
}

public interface ITvShow : IGenredMedia
{
    void CalculateRating();
}


public interface IEpisode : IMedia
{
    int TvShowID { get; set; }
    int Season { get; set; }
    int EpNumber { get; set; }
    TimeSpan Duration { get; set; }
}

