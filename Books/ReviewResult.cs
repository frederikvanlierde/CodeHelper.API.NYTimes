using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace CodeHelper.API.NYTimes.Books
{
    public class ReviewResult : BaseResult
    {

        #region Properties        
        [JsonPropertyName("results")]       public List<ReviewInfo> Reviews { get; set; } = new();
        #endregion
        #region Constructors
        public ReviewResult() { }
        #endregion
    }
}
