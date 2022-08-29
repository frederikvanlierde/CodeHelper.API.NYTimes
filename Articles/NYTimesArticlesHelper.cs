using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using CodeHelper.Core.PlaceHolder;
namespace CodeHelper.API.NYTimes.Articles
{
    public class NYTimesArticlesHelper : NYTimesHelper
    {
        #region Properties               
        [Placeholder("{SOURCE}")] public string Source { get; set; } = "";
        [Placeholder("{SECTION}")] public string Section { get; set; } = "";
        [Placeholder("{RESOURCETYPE}")] public string ResourceType { get; set; } = "";
        [Placeholder("{SHAREDTYPE}")] public string SharedType { get; set; } = "";
        [Placeholder("{PERIOD}")] public int Period { get; set; } = 1;        
        [Placeholder("{FILTER}")] public string SearchFilter { get; set; } = "";

        [Placeholder("{YEAR}")] public int SeachYear { get; set; }
        [Placeholder("{MONTH}")] public int SeachMonth { get; set; }
        #endregion

        #region Constructors
        public NYTimesArticlesHelper() { }
        #endregion

        #region Public Methods
        /// <summary>
        /// Returns an array of NYT articles for a given month, going back to 1851. Its response fields are the same as the Article Search API. 
        /// The Archive API is very useful if you want to build your own database of NYT article metadata. You simply pass the API the year and month and it returns a JSON object with all articles for that month. 
        /// The response size can be large (~20mb).
        /// </summary>
        /// <param name="year">int : year (mandatory)</param>
        /// <param name="month">int : month (mandatory)</param>
        /// <returns>List<docs> : List of available docus</returns>
        public async Task<List<Doc>> GetArticleArchive(int year, int month)
        {
            this.SeachYear = year;
            this.SeachMonth = month;
            return (JsonSerializer.Deserialize<ArticleSearchResult>(await GetJson(Constants.API_URL_ARTICLES_ARCHIVE)) ?? new()).Response.Articles;
        }
        /// <summary>
        /// Look up articles by keyword. 
        /// The Article Search API returns a max of 10 results at a time. 
        /// </summary>
        /// <param name="query">string : keyword to search for (mandatory)</param>
        /// <param name="page">int: Use the page query parameter to paginate thru results (page=0 for results 1-10, page=1 for 11-20, ...). You can paginate thru up to 100 pages (1,000 results).</param>
        /// <param name="sharedType">When selected shared, add the media platform  (ex. Facebook)</param>
        /// <returns>List<docs> : List of available docus</returns>
        public async Task<List<Doc>> ArticleSearch(string qurey, int page = 0)
        {
            this.SearchQuery = qurey.ToLower();
            this.SearchFilter = "(pagination=" + page + ")";
            return (JsonSerializer.Deserialize<ArticleSearchResult>(await GetJson(Constants.API_URL_ARTICLES_SEARCH)) ?? new()).Response.Articles;
        }
        /// <summary>
        /// Returns the most popular articles on NYTimes.com based on emails, shares, or views for specified period of time (1 day, 7 days, or 30 days).
        /// </summary>
        /// <param name="resourceType">string : emailed, shared, viewed , use class ResourcesTypes (Mandatory)</param>
        /// <param name="days">int: 1, 7, 30 (Mandatory)</param>
        /// <param name="sharedType">When selected shared, add the media platform  (ex. Facebook)</param>
        /// <returns>List<Article> : List of available Articles</returns>
        public async Task<List<Article>> GetMostPopularArticles(string resourceType = "", int period = 1, string sharedType = "")
        {
            this.ResourceType = resourceType.ToLower();
            this.Period = period;
            this.SharedType = sharedType.ToLower();
            return (JsonSerializer.Deserialize<ResultArticles>(await GetJson(Constants.API_URL_ARTICLES_MOSTPOPULAR)) ?? new()).Articles;
        }
        /// <summary>
        /// Returns an array of articles currently on the specified section (arts, business, ...).
        /// Use home to get articles currently on the homepage. (Other sections available via GetSections Methdos)
        /// </summary>
        /// <returns>List<Article> : List of available Articles</returns>
        public async Task<List<Article>> GetTopStories(string section = "home")
        {
            this.Section = section.ToLower();
            return (JsonSerializer.Deserialize<ResultArticles>(await GetJson(Constants.API_URL_ARTICLES_TOPSTORIES)) ?? new()).Articles;
        }


        /// <summary>
        /// Get links and metadata for NY Times' articles as soon as they are published on NYTimes.com.
        /// </summary>
        /// <param name="source">string: All, New York Times (nyt), Internation NY Times (inyt) , You can use class SourceTpes</param>
        /// <param name="section">string: all or one of the section available in GetSectionList</param>
        /// <returns>List<Article> : List of available Articles</returns>
        public async Task<List<Article>> GetLatestArticles(string source = SourceTypes.All, string section = "all")
        {
            this.Source = source.ToLower();
            this.Section = section.ToLower();
            return (JsonSerializer.Deserialize<ResultArticles>(await GetJson(Constants.API_URL_ARTICLES_GETLATEST)) ?? new()).Articles;
        }

        /// <summary>
        /// Returns the available sections, like Arts, Business,...
        /// </summary>
        /// <returns>List<SectionDetailY> : List of available sections</returns>
        public async Task<List<SectionDetail>> GetSections()
        {
            return (JsonSerializer.Deserialize<Result>(await GetJson(Constants.API_URL_SECTIONLISTS)) ?? new()).Sections;
        }
        #endregion

    }
}
