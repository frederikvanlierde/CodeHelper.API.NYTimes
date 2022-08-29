using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace CodeHelper.API.NYTimes.Articles
{
    public class Article
    {
        #region Properties
        [JsonPropertyName("slug_name")]             public string SlugName { get; set; } = "";
        [JsonPropertyName("section")]               public string Section { get; set; } = "";
        [JsonPropertyName("subsection")]            public string Subsection { get; set; } = "";
        [JsonPropertyName("title")]                 public string Title { get; set; } = "";
        [JsonPropertyName("abstract")]              public string Abstract { get; set; } = "";
        [JsonPropertyName("uri")]                   public string Uri { get; set; } = "";
        [JsonPropertyName("url")]                   public string Url { get; set; } = "";
        [JsonPropertyName("byline")]                public string Byline { get; set; } = "";
        [JsonPropertyName("thumbnail_standard")]    public string ThumbnailStandard { get; set; } = "";
        [JsonPropertyName("item_type")]             public string ItemType { get; set; } = "";
        [JsonPropertyName("source")]                public string Source { get; set; } = "";
        [JsonPropertyName("updated_date")]          public DateTime UpdatedDate { get; set; }
        [JsonPropertyName("created_date")]          public DateTime CreatedDate { get; set; }
        [JsonPropertyName("published_date")]        public DateTime PublishedDate { get; set; }
        [JsonPropertyName("first_published_date")]  public DateTime FirstPublishedDate { get; set; }
        [JsonPropertyName("material_type_facet")]   public string MaterialTypeFacet { get; set; } = "";
        [JsonPropertyName("kicker")]                public string Kicker { get; set; } = "";
        [JsonPropertyName("subheadline")]           public string Subheadline { get; set; } = "";
        [JsonPropertyName("des_facet")]             public List<string> DesFacet { get; set; } = new();
        [JsonPropertyName("org_facet")]             public List<string> OrgFacet { get; set; } = new();
        [JsonPropertyName("per_facet")]             public List<string> PerFacet { get; set; } = new();
        [JsonPropertyName("geo_facet")]             public List<string> GeoFacet { get; set; } = new();
        [JsonPropertyName("related_urls")]          public List<string> RelatedUrls { get; set; } = new();
        [JsonPropertyName("multimedia")]            public List<Multimedia> Multimedia { get; set; } = new();
    
        #endregion

        #region COnstructors
        public Article() { }
        #endregion
    }
}
