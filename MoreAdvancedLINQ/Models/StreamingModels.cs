namespace Streaming.Models;

public class Media : IMedia
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int[] GenreIds { get; set; }
    public float Rating { get; set; }

    public Media (string name, int[] genreIds, float rating)
    {
        Name = name;
        GenreIds = genreIds;
        Rating = rating;
    }
}

public class Movie : Media, IMovie
{
    public TimeSpan Duration { get; set; }

    public Movie (string name, int[] genreIds, float rating, TimeSpan duration) : base(name, genreIds, rating)
    {
        Duration = duration;
    }
}

public class TvShow : Media, ITvShow
{
    public int TvShowID { get; set; }
    public TvShow (string name, int[] genreIds, float rating, int id) : base(name, genreIds, rating)
    {
        TvShowID = id;
    }

    public void CalculateRating() {}
}