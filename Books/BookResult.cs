using System;
using System.Text.Json.Serialization;

namespace CodeHelper.API.NYTimes.Books
{
    public class BookResult
    {

        #region Properties
        [JsonPropertyName("status")]        public string Status { get; set; } = "";
        [JsonPropertyName("copyright")]     public string Copyright { get; set; } = "";
        [JsonPropertyName("num_results")]   public int NumResults { get; set; }
        [JsonPropertyName("last_modified")] public DateTime LastModified { get; set; }
        [JsonPropertyName("results")]       public ListInfo ListInfo { get; set; } = new();
        #endregion

        #region Constructors
        public BookResult() { }
        #endregion
    }
}
