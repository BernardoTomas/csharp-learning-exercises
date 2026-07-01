namespace Streaming.Models;

public interface IMedia
{
    string Name { get; set; }
    int GenreId { get; set; }
    float Rating { get; set; }
}

public interface IMovie : IMedia
{
    TimeSpan Duration { get; set; }
}

public interface ITvShow : IMedia
{
    int Seasons { get; set; }
    int TotalEpisodes { get; set; }
}

// Create IEpisode, make a structure for keeping episodes in a tv show

public interface IGenreRepo
{
    string getGenreById(int id);
}