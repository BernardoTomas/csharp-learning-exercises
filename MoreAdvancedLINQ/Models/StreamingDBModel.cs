namespace Streaming.Models;

public class StreamingDBModel
{
    private List<IMovie> _movieList { get; set; } = new List<IMovie>();
    private List<ITvShow> _tvShowList { get; set; } = new List<ITvShow>();
    private List<IEpisode> _episodeList { get; set; } = new List<IEpisode>();

    
}