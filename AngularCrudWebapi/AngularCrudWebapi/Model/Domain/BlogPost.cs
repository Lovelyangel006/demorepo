using System.ComponentModel.DataAnnotations;

namespace AngularCrudWebapi.Model.Domain
{
    public class BlogPost
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }

        public string ShortDescription { get; set; }
        public string Content { get; set; }
        public string FeatureIamgeUrl { get; set; }
        public string UrlHandler { get; set; }

        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public bool IsVisible { get; set; }
    }
}
