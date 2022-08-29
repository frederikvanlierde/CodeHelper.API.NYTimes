using System.Text.Json.Serialization;

namespace CodeHelper.API.NYTimes
{
    public class Result
    {
        #region Properties
        [JsonPropertyName("status")]        public string Status { get; set; } = "";
        [JsonPropertyName("copyright")]     public string Copyright { get; set; } = "";
        [JsonPropertyName("num_results")]   public int NumResults { get; set; }
        [JsonPropertyName("results")]       public List<SectionDetail> Sections { get; set; } = new();
        #endregion

        #region constructors
        public Result() { }
        #endregion
    }
}
