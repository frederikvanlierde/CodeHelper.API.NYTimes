using System.Text.Json.Serialization;


namespace CodeHelper.API.NYTimes
{
    public class BaseResult
    {
        #region Properties
        [JsonPropertyName("status")] public string Status { get; set; } = "";
        [JsonPropertyName("copyright")] public string Copyright { get; set; } = "";
        [JsonPropertyName("num_results")] public int NumResults { get; set; }
        #endregion
        #region Constructors
        public BaseResult() { }
        #endregion
    }
}
