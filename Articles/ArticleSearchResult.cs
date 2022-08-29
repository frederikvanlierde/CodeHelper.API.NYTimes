using System.Text.Json.Serialization;

namespace CodeHelper.API.NYTimes.Articles
{
    public  class ArticleSearchResult
    {
        #region Properties
        [JsonPropertyName("status")]    public string Status { get; set; } = "";

        [JsonPropertyName("copyright")] public string Copyright { get; set; } = "";

        [JsonPropertyName("response")]  public Docs Response { get; set; } = new();
        #endregion
    }
}
