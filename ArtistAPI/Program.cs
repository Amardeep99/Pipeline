using ArtistAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string token = "Bearer BQAkEwyxi0JBuU8YNvx-RjPwN7somFeNRgIDCkNSMvFJVoRVwOdnkXbIFOlYjbnnwrcJuTXLPNF8NDtc3ZrDpEYsddTB5DHbmKGvOP2PWJxdWmrtMQA";
string spotifyApiHost = "https://api.spotify.com/v1/artists";

builder.Services.AddControllers();
builder.Services.AddHttpClient<ISpotifyClient, SpotifyClient>(client => {
	client.BaseAddress = new Uri(spotifyApiHost);
	client.DefaultRequestHeaders.Add("Authorization", token);
});

builder.Services.AddSingleton(new ArtistRepo());


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
