using System.Text.Json;
using CodeHelper.Core.PlaceHolder;
namespace CodeHelper.API.NYTimes
{
    public class NYTimesHelper
    {
        #region Properties
        public string AppName { get; set; } = "";
        private readonly HttpClient _httpClient = new();
        [Placeholder("{APIKEY}")] public string ApiKey { get; set; } = "";
        
        [Placeholder("{SOURCE}")] public string Source { get; set; } = "";
        [Placeholder("{SECTION}")] public string Section { get; set; } = "";
        #endregion

        #region Constructors
        private NYTimesHelper() { }
        public NYTimesHelper(string appName, string apiKey)
        {
            this.AppName = appName;
            this.ApiKey = apiKey;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Returns the available sections, like Art, Business,...
        /// </summary>
        /// <returns>List<SectionDetailY> : List of available sections</returns>
        public async Task<List<SectionDetail>> GetSectionLists()
        {
            return (JsonSerializer.Deserialize<Result>(await GetJson(Constants.API_URL_SECTIONLISTS)) ?? new()).Sections;
        }

        /// <summary>
        /// Get links and metadata for Times' articles as soon as they are published on NYTimes.com.
        /// </summary>
        /// <param name="source">string: All, New York Times (nyt), Internation NY Times (inyt) , You can use class SourceTpes</param>
        /// <param name="section">string: all or one of the section available in GetSectionList</param>
        /// <returns>List<SectionDetailY> : List of available sections</returns>
        public async Task<List<Article>> GetArticles(string source = SourceTypes.All, string section = "all")
        {
            this.Source = source.ToLower();
            this.Section = section.ToLower();
            return (JsonSerializer.Deserialize<ResultArticles>(await GetJson(Constants.API_URL_GETARTICLES)) ?? new()).Articles;
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
        #endregion

        #region Private Methods
        protected async Task<string> GetJson(string apiURL)
        {
            apiURL = apiURL.Replace(this);
            _httpClient.DefaultRequestHeaders.Add("user-agent", this.AppName);
            var _task = await _httpClient.GetAsync(apiURL);
            return await _task.Content.ReadAsStringAsync();
        }
        #endregion
    }
}