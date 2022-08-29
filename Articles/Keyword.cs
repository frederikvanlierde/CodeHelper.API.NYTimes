using System.Text.Json.Serialization;

namespace CodeHelper.API.NYTimes.Articles
{
    public class Keyword
    {
        #region Properties
        [JsonPropertyName("name")]  public string Name { get; set; } = "";
        [JsonPropertyName("value")] public string Value { get; set; } = "";
        [JsonPropertyName("rank")]  public int Rank { get; set; }
        [JsonPropertyName("major")] public string Major { get; set; } = "";
        #endregion

        #region Constructors
        public Keyword() { }
        #endregion
    }

}
