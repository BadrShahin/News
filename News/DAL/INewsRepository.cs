using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News.DAL
{
    public interface INewsRepository : IDisposable
    {
        IEnumerable<News.Models.News> GetNews();

        News.Models.News GetNewsByID(long NewsId);

        void InsertNews(News.Models.News news);

        void DeleteNews(long NewsId);

        void UpdateNews(News.Models.News news);

        void Save();
    }
}
