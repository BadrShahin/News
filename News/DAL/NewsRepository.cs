using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using News.Models;
using Microsoft.EntityFrameworkCore;

namespace News.DAL
{
    public class NewsRepository : INewsRepository, IDisposable
    {
        private NewsContext context;

        public NewsRepository(NewsContext context)
        {
            this.context = context;
        }

        public IEnumerable<Models.News> GetNews()
        {
            return context.News.ToList();
        }

        public Models.News GetNewsByID(long NewsId)
        {
            return context.News.Find(NewsId);
        }

        public void InsertNews(Models.News news)
        {
            context.News.Add(news);
        }

        public void UpdateNews(Models.News news)
        {
            context.Entry(news).State = EntityState.Modified;
        }

        public void DeleteNews(long NewsId)
        {
            Models.News oldNews = context.News.Find(NewsId);
            context.News.Remove(oldNews);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        #region IDisposable Support
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
