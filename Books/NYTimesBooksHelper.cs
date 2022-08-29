using System.Text.Json;
using CodeHelper.Core.PlaceHolder;
using System.Web;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CodeHelper.API.NYTimes.Books
{
    public  class NYTimesBooksHelper : NYTimesHelper
    {
        #region properties
        [Placeholder("{DATE}")] public string ListDate { get; set; } = "current";
        [Placeholder("{LISTNAME}")] public string ListName { get; set; } = "";

        [Placeholder("{REVIEWBYTYPE}")] public string ReviewByType { get; set; } = "";
        [Placeholder("{REVIEWBYVALUE}")] public string ReviewByValue { get; set; } = "";
        
        #endregion

        #region Constructors
        public NYTimesBooksHelper() { }
        #endregion

        #region Public Methods
        /// <summary>
        /// Returns a list of all the NYT Best Sellers Lists. Some lists are published weekly and others monthly. The response includes when each list was first published and last published.
        /// </summary>       
        public async Task<List<ListInfo>> GetBestSellerLists()
        {
            return (JsonSerializer.Deserialize<ListResult>(await GetJson(Constants.API_URL_BOOKS_BESTSELLERLISTS)) ?? new()).Lists;
        }

        /// <summary>
        /// Returns a list of all the NYT Best Sellers Lists. Some lists are published weekly and others monthly. The response includes when each list was first published and last published.
        /// </summary>       
        /// <param name="date">string : yyy-mm-dd (Use "current" for date to get the latest list.)</param>
        /// <param name="listName">string : Name of list (See GetBestSellerLists Method </param>
        public async Task<ListInfo> GetBooksOnList(string listName, string date ="current")
        {
            this.ListDate = date;
            this.ListName = listName;
            return (JsonSerializer.Deserialize<BookResult>(await GetJson(Constants.API_URL_BOOKS_ONLIST)) ?? new()).ListInfo;
        }
        /// <summary>
        /// Returns a list NYT book review by author, ISBN, or title.
        /// </summary>       
        /// <param name="reviewByType">string : author, ISBN, or title. (Use the ReviewByTpyes Class)  (Mandatory)</param>
        /// <param name="reviewByValue">string : the vakue for the choosen ReviewByType (Mandatory)</param>
        public async Task<List<ReviewInfo>> GetBookReviews(string reviewByType, string reviewByValue)
        {
            this.ReviewByType = reviewByType;
            this.ReviewByValue = HttpUtility.UrlEncode(reviewByValue);
            return (JsonSerializer.Deserialize<ReviewResult>(await GetJson(Constants.API_URL_REVIEWS_GETBY)) ?? new()).Reviews;
        }
        #endregion
    }
}

