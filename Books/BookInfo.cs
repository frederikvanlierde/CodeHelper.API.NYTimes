using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CodeHelper.API.NYTimes.Books
{
    public class BookInfo
    {

        #region Properties
        [JsonPropertyName("rank")]                  public int Rank { get; set; }
        [JsonPropertyName("rank_last_week")]        public int RankLastWeek { get; set; }
        [JsonPropertyName("weeks_on_list")]         public int WeeksOnList { get; set; }
        [JsonPropertyName("asterisk")]              public int Asterisk { get; set; }
        [JsonPropertyName("dagger")]                public int Dagger { get; set; }
        [JsonPropertyName("primary_isbn10")]        public string PrimaryIsbn10 { get; set; } = "";
        [JsonPropertyName("primary_isbn13")]        public string PrimaryIsbn13 { get; set; } = "";
        [JsonPropertyName("publisher")]             public string Publisher { get; set; } = "";
        [JsonPropertyName("description")]           public string Description { get; set; } = "";
        [JsonPropertyName("price")]                 public string Price { get; set; } = "";
        [JsonPropertyName("title")]                 public string Title { get; set; } = "";
        [JsonPropertyName("author")]                public string Author { get; set; } = "";
        [JsonPropertyName("contributor")]           public string Contributor { get; set; } = "";
        [JsonPropertyName("contributor_note")]      public string ContributorNote { get; set; } = "";
        [JsonPropertyName("book_image")]            public string BookImage { get; set; } = "";
        [JsonPropertyName("book_image_width")]      public int BookImageWidth { get; set; }
        [JsonPropertyName("book_image_height")]     public int BookImageHeight { get; set; }
        [JsonPropertyName("amazon_product_url")]    public string AmazonProductUrl { get; set; } = "";
        [JsonPropertyName("age_group")]             public string AgeGroup { get; set; } = "";
        [JsonPropertyName("book_review_link")]      public string BookReviewLink { get; set; } = "";
        [JsonPropertyName("first_chapter_link")]    public string FirstChapterLink { get; set; } = "";
        [JsonPropertyName("sunday_review_link")]    public string SundayReviewLink { get; set; } = "";
        [JsonPropertyName("article_chapter_link")]  public string ArticleChapterLink { get; set; } = "";
        [JsonPropertyName("isbns")]                 public List<Isbn> Isbns { get; set; } = new();
        [JsonPropertyName("buy_links")]             public List<BuyLink> BuyLinks { get; set; } = new();
        [JsonPropertyName("book_uri")]              public string BookUri { get; set; } = "";
        #endregion
        #region Constructors
        public BookInfo() { }
        #endregion
    }
}
