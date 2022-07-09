using lolPlay.Data.Models;

namespace lolPlay.Data.Interfaces
{
    public interface ICatalogMedia
    {
        IEnumerable<Media> GetMedias();
        Media GetMedia(int mediaId);
    }
}
