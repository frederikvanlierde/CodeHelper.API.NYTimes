using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace CodeHelper.API.NYTimes.Books
{
    public class ReviewResult
    {

        #region Properties
        [JsonPropertyName("status")]        public string Status { get; set; } = "";
        [JsonPropertyName("copyright")]     public string Copyright { get; set; } = "";
        [JsonPropertyName("num_results")]   public int NumResults { get; set; }
        [JsonPropertyName("results")]       public List<ReviewInfo> Reviews { get; set; } = new();
        #endregion
        #region Constructors
        public ReviewResult() { }
        #endregion
    }
}
