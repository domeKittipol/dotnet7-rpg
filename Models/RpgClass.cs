using System.Text.Json.Serialization;
namespace dotnet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Warrior = 2,
        Assassins = 3,
        Gambler = 4,
        Magician = 5,
        Summoner = 6,
        Guardian = 7,
        Berserker = 8,
        Hunter = 9,
        MatialArtist = 10,
        Sniper = 11,
        Priest = 12

    }
}