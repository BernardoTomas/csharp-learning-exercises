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

    public void AddEpisode(IEpisode episode)
    {
        episode.Id = _idGenerator.GenerateId("3");
        _episodeList.Add(episode);
    }
    public void AddMedia (IMedia media)
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
                AddEpisode(episode);
                break;
            default:
                throw new ArgumentException("Media Type is not Movie, TvShow, or Episode");
        }
    }

    public List<IGenredMedia> GetMediaByGenre (int genreQuery)
    {
        List<IGenredMedia> allGenredMedia = _movieList.Concat<IGenredMedia>(_tvShowList).ToList();
        
        var mediaByGenre =
            from mediaItem in allGenredMedia
                where mediaItem.GenreIds.Contains(genreQuery)
            select mediaItem;

        return mediaByGenre.ToList();
    }
}