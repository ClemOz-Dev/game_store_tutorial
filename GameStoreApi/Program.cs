using GameStoreApi.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games = [
  new(
    1,
    "Street Fighter II",
    "Fighting",
    19.99M,
    new DateOnly(1992,7,15)
  ),  
  new(
    2,
    "Final Fantasy XIV",
    "Roleplaying",
    59.99M,
    new DateOnly(2010,9,30)
  ),  
  new(
    3,
    "FIFA 2023",
    "Sports",
    69.99M,
    new DateOnly(2022,9,27)
  ),  
];

app.MapGet("/", () => "Hello World!");

app.MapGet("/games", () => games);

app.Run();
