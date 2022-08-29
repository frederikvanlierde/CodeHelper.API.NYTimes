using System.Text.Json.Serialization;


namespace CodeHelper.API.NYTimes.Movies
{
    public class Link
    {
        #region Properties
        [JsonPropertyName("type")]                  public string Type { get; set; } = "";
        [JsonPropertyName("url")]                   public string Url { get; set; } = "";
        [JsonPropertyName("suggested_link_text")]   public string SuggestedLinkText { get; set; } = "";

        #endregion
        #region Constructors
        public Link() { }
        #endregion
    }
}
