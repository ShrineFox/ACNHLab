using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ACNHLab.Classes
{
    public class Amiibo
    {
        public struct AmiiboJson
        {
            [JsonPropertyName("amiibo")]
            public List<AmiiboApi> List { get; set; }
            [JsonPropertyName("lastUpdated")]
            public DateTime LastUpdated { get; set; }
        }

        public struct AmiiboApi
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }
            [JsonPropertyName("head")]
            public string Head { get; set; }
            [JsonPropertyName("tail")]
            public string Tail { get; set; }
            [JsonPropertyName("image")]
            public string Image { get; set; }
            [JsonPropertyName("amiiboSeries")]
            public string AmiiboSeries { get; set; }
            [JsonPropertyName("character")]
            public string Character { get; set; }
            [JsonPropertyName("gameSeries")]
            public string GameSeries { get; set; }
            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonPropertyName("release")]
            public Dictionary<string, string> Release { get; set; }

            [JsonPropertyName("gamesSwitch")]
            public List<AmiiboApiGamesSwitch> GamesSwitch { get; set; }
        }

        public class AmiiboApiGamesSwitch
        {
            [JsonPropertyName("amiiboUsage")]
            public List<AmiiboApiUsage> AmiiboUsage { get; set; }
            [JsonPropertyName("gameID")]
            public List<string> GameId { get; set; }
            [JsonPropertyName("gameName")]
            public string GameName { get; set; }
        }

        public class AmiiboApiUsage
        {
            [JsonPropertyName("Usage")]
            public string Usage { get; set; }
            [JsonPropertyName("write")]
            public bool Write { get; set; }
        }
    }
}
