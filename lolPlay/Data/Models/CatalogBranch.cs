namespace lolPlay.Data.Models
{
    public class CatalogBranch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public List<Media>? Medias { get; set; }
        public List<CatalogBranch>? ChildrenBranches { get; set; }

    }
}
