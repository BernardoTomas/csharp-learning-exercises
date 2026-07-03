namespace Streaming.Models;

public class StreamingDBModel
{
    private IdGenerator _idGenerator = new();
    private List<IMovie> _movieList { get; set; } = new List<IMovie>();
    private List<ITvShow> _tvShowList { get; set; } = new List<ITvShow>();
    private List<IEpisode> _episodeList { get; set; } = new List<IEpisode>();

    public void AddMovie(IMovie movie)
    {
        movie.Id = _idGenerator.GenerateId("1");
        _movieList.Add(movie);
    }

    public void AddTvShow(ITvShow tvShow)
    {
        tvShow.Id = _idGenerator.GenerateId("2");
        _tvShowList.Add(tvShow);
    }

    public void AddEpisode(IEpisode episode, string tvShowRefId)
    {
        if (string.IsNullOrEmpty(tvShowRefId)) throw new ArgumentException("Episode must have a TvShowRefID");

        episode.TvShowRefID = tvShowRefId;
        episode.Id = _idGenerator.GenerateId("3");
        _episodeList.Add(episode);
    }
    public void AddMedia (IMedia media, string tvShowRefId = "")
    {
        switch (media)
        {
            case IMovie movie:
                AddMovie(movie);
                break;
            case ITvShow tvShow:
                AddTvShow(tvShow);
                break;
            case IEpisode episode:
                AddEpisode(episode, tvShowRefId);
                break;
            default:
                throw new ArgumentException("Media Type is not Movie, TvShow, or Episode");
        }
    }
}