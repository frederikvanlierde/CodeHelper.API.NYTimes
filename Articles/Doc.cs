using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CodeHelper.API.NYTimes.Articles
{
    public class Doc
    {
        #region Properties
        [JsonPropertyName("abstract")]          public string Abstract { get; set; } = "";
        [JsonPropertyName("web_url")]           public string WebUrl { get; set; } = "";
        [JsonPropertyName("snippet")]           public string Snippet { get; set; } = "";
        [JsonPropertyName("lead_paragraph")]    public string LeadParagraph { get; set; } = "";
        [JsonPropertyName("print_page")]        public string PrintPage { get; set; } = "";
        [JsonPropertyName("source")]            public string Source { get; set; } = "";
        [JsonPropertyName("multimedia")]        public List<Multimedia> Multimedium { get; set; } = new();
        [JsonPropertyName("headline")]          public Headline Headline { get; set; } = new();
        [JsonPropertyName("keywords")]          public List<Keyword> Keywords { get; set; } = new();
        [JsonPropertyName("pub_date")]          public string PubDate { get; set; } = "";
        [JsonPropertyName("document_type")]     public string DocumentType { get; set; } = "";
        [JsonPropertyName("news_desk")]         public string NewsDesk { get; set; } = "";
        [JsonPropertyName("section_name")]      public string SectionName { get; set; } = "";
        [JsonPropertyName("byline")]            public Byline Byline { get; set; } = new();
        [JsonPropertyName("type_of_material")]  public string TypeOfMaterial { get; set; } = "";
        [JsonPropertyName("_id")]               public string Id { get; set; } = "";
        [JsonPropertyName("word_count")]        public int WordCount { get; set; }
        [JsonPropertyName("uri")]               public string Uri { get; set; } = "";
        [JsonPropertyName("print_section")]     public string PrintSection { get; set; } = "";
        [JsonPropertyName("subsection_name")]   public string SubsectionName { get; set; } = "";
        #endregion

        #region Constructors
        public Doc() { }
        #endregion
    }
}
