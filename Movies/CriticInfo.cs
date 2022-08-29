using System.Text.Json.Serialization;


namespace CodeHelper.API.NYTimes.Movies
{
    public class CriticInfo
    {

        #region Properties
        [JsonPropertyName("display_name")]  public string DisplayName { get; set; } = "";
        [JsonPropertyName("sort_name")]     public string SortName { get; set; } = "";
        [JsonPropertyName("status")]        public string Status { get; set; } = "";
        [JsonPropertyName("bio")]           public string Bio { get; set; } = "";
        [JsonPropertyName("seo_name")]      public string SeoName { get; set; } = "";
        [JsonPropertyName("multimedia")]    public Multimedia Multimedia { get; set; }
        #endregion
        #region Constructors
        public CriticInfo() { }
        #endregion
    }
}
