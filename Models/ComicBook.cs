namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SerisTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml  { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }
    }
}
