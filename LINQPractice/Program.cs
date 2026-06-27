using ArtistsLists;
using System.Linq;

List<Artist> artists = new List<Artist> 
{
    new Artist{ Name = "Raul Seixas", Listeners = 50000 },
    new Artist{ Name = "Mozart", Listeners = 15000 },
    new Artist{ Name = "Elvis Presley", Listeners = 25000 },
    new Artist{ Name = "Bob Dylan", Listeners = 30000 },
    new Artist{ Name = "Guns n' Roses", Listeners = 40000 }
};

var topListeners = from artist in artists
                    where artist.Listeners > 30000
                    select artist.Name;

foreach(var artist in topListeners)
{
    Console.WriteLine(artist);
}