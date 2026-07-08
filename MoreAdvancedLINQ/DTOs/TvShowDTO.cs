namespace Streaming.Models;

public class TvShowDTO
{
    public string? Title { get; set; }
    public int? SeasonsCount { get; set; }
    public int? EpisodeCount { get; set; }
    public string[]? Genres { get; set; }
    public TimeSpan? TotalDuration { get; set; }
    public string? errMessage { get; set; }
}