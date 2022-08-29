using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using CodeHelper.Core.PlaceHolder;
using System.Web;

namespace CodeHelper.API.NYTimes.Movies
{
    public class NYTimesMoviesHelper : NYTimesHelper
    {
        #region Properties
        [Placeholder("{CRITICNAME}")] public string CriticName { get; set; } = "";
        [Placeholder("{DATEPERIOD}")] public string DatePeriod { get; set; } = ""; 
        #endregion
        #region Constructors
        public NYTimesMoviesHelper() { }
        #endregion

        #region Public Methods
        /// <summary>
        /// Returns a liist of movie critic names
        /// </summary>       
        /// <param name="reviewByType">string : author, ISBN, or title. (Use the ReviewByTpyes Class)  (Mandatory)</param>
        /// <param name="reviewByValue">string : the vakue for the choosen ReviewByType (Mandatory)</param>
        public async Task<List<CriticInfo>> GetCriticNames()
        {            
            return (JsonSerializer.Deserialize<CriticsResults>(await GetJson(Constants.API_URL_MOVIES_GETCRITICSNAMES)) ?? new()).Critics;
        }
        /// <summary>
        /// Get movie reviews that are critics' picks:
        /// </summary>
        /// <returns>Returns a list of Movie Reviews</returns>
        public async Task<List<MovieReview>> GetCriticsPicks()
        {
            return (JsonSerializer.Deserialize<ReviewResult>(await GetJson(Constants.API_URL_MOVIES_GETCRITICSPICKS)) ?? new()).MovieReviews;
        }

        /// <summary>
        /// Get movie reviews that are critics' picks:
        /// </summary>
        /// <param name="query">string words in title of a movie (mandatory)</param>
        /// <param name="dateFrom">string date from when you like to search yyyy-mm-dd</param>
        /// <param name="dateTo">string date until when you like to search yyyy-mm-dd</param>
        /// <returns>Returns a list of Movie Reviews</returns>
        public async Task<List<MovieReview>> Search(string query, string dateFrom ="", string dateTo ="")
        {
            this.SearchQuery = HttpUtility.UrlEncode(query).ToLower();
            this.DatePeriod = dateFrom + (string.IsNullOrEmpty(dateTo) ? "" : ":" + dateTo);

            return (JsonSerializer.Deserialize<ReviewResult>(await GetJson(Constants.API_URL_MOVIES_SEARCH)) ?? new()).MovieReviews;
        }


        /// <summary>
        /// Returns movie reviews for the given critic
        /// </summary>       
        /// <param name="criticName">string : name f the critics, for full list see GetCriticNames method  (Mandatory)</param>
        //public async Task<List<MutlimediaResource>> GetReviewsByCritic(string criticName)
        //{
        //    /// NO REVIEW RETURNS  NEED TO REVIEW WITH NYTIMES
        //    this.CriticName = criticName;
        //    return (JsonSerializer.Deserialize<CriticsResults>(await GetJson(Constants.API_URL_MOVIES_GETCRITICSNAMES)) ?? new()).Critics[0].Multimedia.Resources;
        //}

        #endregion

    }
}
