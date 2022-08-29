using System.Text.Json.Serialization;

namespace CodeHelper.API.NYTimes.Articles
{
    public class Headline
    {
        #region Properties
        [JsonPropertyName("main")]      public string Main { get; set; } = "";
        [JsonPropertyName("kicker")]    public string Kicker { get; set; } = "";
        [JsonPropertyName("content_kicker")]    public object ContentKicker { get; set; }
        [JsonPropertyName("print_headline")]    public string PrintHeadline { get; set; } = "";
        [JsonPropertyName("name")]      public object Name { get; set; }
        [JsonPropertyName("seo")]       public object Seo { get; set; }
        [JsonPropertyName("sub")]       public object Sub { get; set; }
        #endregion

        #region Constructors
        public Headline() { }
        #endregion
    }

}
