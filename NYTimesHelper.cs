using CodeHelper.Core.PlaceHolder;
using System.Net.Http;
using System.Threading.Tasks;


namespace CodeHelper.API.NYTimes
{
    public class NYTimesHelper
    {
        #region Properties
        private readonly HttpClient _httpClient = new();
        [Placeholder("{APIKEY}")] public string ApiKey { get; set; } = "";
        [Placeholder("{QUERY}")] public string SearchQuery { get; set; } = "";
        #endregion

        #region Constructors
        public NYTimesHelper() { }

        #endregion

        #region Public Methods        
        public void Dispose()
        {
            _httpClient.Dispose();
        }
        #endregion

        #region Private Methods
        protected async Task<string> GetJson(string apiURL)
        {
            apiURL = apiURL.Replace(this).Replace("/.json",".json");
            var _task = await _httpClient.GetAsync(apiURL);
            return await _task.Content.ReadAsStringAsync();
        }
        #endregion
    }
}