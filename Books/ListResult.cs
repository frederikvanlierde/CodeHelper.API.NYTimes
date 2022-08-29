
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CodeHelper.API.NYTimes.Books
{
    public class ListResult
    {
        #region Properties
        [JsonPropertyName("status")]        public string Status { get; set; } = "";
        [JsonPropertyName("copyright")]     public string Copyright { get; set; } = "";
        [JsonPropertyName("num_results")]   public int NumResults { get; set; }
        [JsonPropertyName("results")]       public List<ListInfo> Lists { get; set; } = new();
        #endregion

        #region Constructors
        public ListResult() { }
        #endregion

    }
}
