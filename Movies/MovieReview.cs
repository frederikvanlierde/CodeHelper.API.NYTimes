using System.Text.Json.Serialization;


namespace CodeHelper.API.NYTimes.Movies
{
    public class MovieReview
    {
        #region Properties
        [JsonPropertyName("display_title")] public string DisplayTitle { get; set; } = "";
        [JsonPropertyName("mpaa_rating")]   public string MpaaRating { get; set; } = "";
        [JsonPropertyName("critics_pick")]  public int CriticsPick { get; set; }
        [JsonPropertyName("byline")]        public string Byline { get; set; } = "";
        [JsonPropertyName("headline")]      public string Headline { get; set; } = "";
        [JsonPropertyName("summary_short")] public string SummaryShort { get; set; } = "";
        [JsonPropertyName("publication_date")]  public string PublicationDate { get; set; } = "";
        [JsonPropertyName("opening_date")]  public string OpeningDate { get; set; } = "";
        [JsonPropertyName("date_updated")]  public string DateUpdated { get; set; } = "";
        [JsonPropertyName("link")]          public Link LinkInfo { get; set; }
        [JsonPropertyName("multimedia")]    public MutlimediaResource Multimedia { get; set; } = new();
        #endregion

        #region Constructors
        public MovieReview() { }
        #endregion
    }
}
