using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace CodeHelper.API.NYTimes.Movies
{
    public class ReviewResult : BaseResult
    {
        #region Properties        
        [JsonPropertyName("has_more")]      public bool HasMore { get; set; }   
        [JsonPropertyName("results")]       public List<MovieReview> MovieReviews { get; set; }
        #endregion
        #region Constructors
        public ReviewResult() { }
        #endregion
    }
}
