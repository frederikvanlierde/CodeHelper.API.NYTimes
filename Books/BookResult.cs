using System;
using System.Text.Json.Serialization;

namespace CodeHelper.API.NYTimes.Books
{
    public class BookResult : BaseResult
    {

        #region Properties        
        [JsonPropertyName("last_modified")] public DateTime LastModified { get; set; }
        [JsonPropertyName("results")]       public ListInfo ListInfo { get; set; } = new();
        #endregion

        #region Constructors
        public BookResult() { }
        #endregion
    }
}
