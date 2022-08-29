using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace CodeHelper.API.NYTimes.Books
{
    public class ListInfo
    {
        #region Properties
        [JsonPropertyName("list_name")]             public string ListName { get; set; } = "";
        [JsonPropertyName("list_name_encoded")]     public string ListNameEncoded { get; set; } = "";
        [JsonPropertyName("bestsellers_date")]      public string BestsellersDate { get; set; } = "";
        [JsonPropertyName("published_date")]        public string PublishedDate { get; set; } = "";
        [JsonPropertyName("published_date_description")]    public string PublishedDateDescription { get; set; } = "";
        [JsonPropertyName("next_published_date")]   public string NextPublishedDate { get; set; } = "";
        [JsonPropertyName("previous_published_date")]   public string PreviousPublishedDate { get; set; } = "";
        [JsonPropertyName("display_name")]          public string DisplayName { get; set; } = "";
        [JsonPropertyName("normal_list_ends_at")]   public int NormalListEndsAt { get; set; }
        [JsonPropertyName("updated")]               public string Updated { get; set; } = "";
        [JsonPropertyName("books")]                 public List<BookInfo> Books { get; set; } = new();
        [JsonPropertyName("corrections")]           public List<object> Corrections { get; set; } = new();

        [JsonPropertyName("oldest_published_date")] public string OldestPublishedDate { get; set; } = "";
        [JsonPropertyName("newest_published_date")] public string NewestPublishedDate { get; set; } = "";

        #endregion

        #region Properties
        public ListInfo() { }
        #endregion
    }

}
