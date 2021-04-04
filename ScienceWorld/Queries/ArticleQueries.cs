using Cassandra;
using ScienceWorld.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScienceWorld.Queries
{
    public static class ArticleQueries
    {
        /*public static List<Article> GetArticleByUsername(string username)
        {
            ISession session = SessionManager.GetSession();
            List<Article> articles = new List<Article>();

            if (session == null)
                return null;

            var articleData = session.Execute("select * from \"article\" where username='" + username + "'").ToList();
            foreach (var art in articleData)
            {
                Article article = new Article();
                article.title = art["title"] != null ? art["title"].ToString() : string.Empty;
                article.username = art["username"] != null ? art["username"].ToString() : string.Empty;
                //article.uploaddate = art["uploaddate"] != null ? (DateTime)art["uploaddate"] : DateTime.MinValue; //Da li je tacno??
                article.articletext = art["articletext"] != null ? art["articletext"].ToString() : string.Empty;
                article.fieldofscience = art["fieldofscience"] != null ? art["fieldofscience"].ToString() : string.Empty;
                //article.subfieldofscience = art["subfieldofscience"] != null ? art["subfieldofscience"].ToString() : string.Empty;
                article.comments = art["comments"] != null ? (List<Comment>)art["comments"] : null;   //?????????????????

                articles.Add(article);
            }
            return articles;
        }*/
        public static void AddArticle(string title, string fieldofscience, string articletext)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;
            var dateadded = DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss");
            RowSet articleData = session.Execute("insert into article (username, title, uploaddate, articletext, fieldofscience) values ('" + Global.ActiveUser.username + "', '" + title + "', '" + dateadded + "', '" + articletext  + "' ,'" + fieldofscience +"')");
        }
        public static List<Article> GetArticleByScienceField(string username, string field)
        {
            ISession session = SessionManager.GetSession();
            List<Article> articles = new List<Article>();

            if (session == null)
                return null;

            var articleData = session.Execute("select * from \"article\" where username='" + username + "' and fieldofscience='" + field + "'").ToList();
            foreach (var art in articleData)
            {
                Article article = new Article();
                article.title = art["title"] != null ? art["title"].ToString() : string.Empty;
                article.username = art["username"] != null ? art["username"].ToString() : string.Empty;
                article.uploaddate = DateTime.Parse(art["uploaddate"].ToString());
                article.articletext = art["articletext"] != null ? art["articletext"].ToString() : string.Empty;
                article.fieldofscience = art["fieldofscience"] != null ? art["fieldofscience"].ToString() : string.Empty;

                articles.Add(article);
            }
            return articles;
        }
        public static List<Article> GetArticleByScienceFieldAndTitle(string username, string field, string title)
        {
            ISession session = SessionManager.GetSession();
            List<Article> articles = new List<Article>();

            if (session == null)
                return null;

            var articleData = session.Execute("select * from \"article\" where username='" + username + "' and fieldofscience='" + field + "'").ToList();
            foreach (var art in articleData)
            {
                Article article = new Article();
                article.title = art["title"] != null ? art["title"].ToString() : string.Empty;
                article.username = art["username"] != null ? art["username"].ToString() : string.Empty;
                article.uploaddate = DateTime.Parse(art["uploaddate"].ToString());
                article.articletext = art["articletext"] != null ? art["articletext"].ToString() : string.Empty;
                article.fieldofscience = art["fieldofscience"] != null ? art["fieldofscience"].ToString() : string.Empty;

                articles.Add(article);
            }
            return articles;
        }
        public static void DeleteArticle(string username, string field, string title)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet articleData = session.Execute("delete from article where username = '" + username + "' and title='" + title + "'");
        }
        
        public static List<Article> GetArticleByOnlyScienceField(string field)
        {
            ISession session = SessionManager.GetSession();
            List<Article> articles = new List<Article>();

            if (session == null)
                return null;

            var articleData = session.Execute("select * from \"article\" where fieldofscience ='" + field + "'").ToList();
            foreach (var art in articleData)
            {
                Article article = new Article();
                article.title = art["title"] != null ? art["title"].ToString() : string.Empty;
                article.username = art["username"] != null ? art["username"].ToString() : string.Empty;
                article.uploaddate = DateTime.Parse(art["uploaddate"].ToString());
                article.articletext = art["articletext"] != null ? art["articletext"].ToString() : string.Empty;
                article.fieldofscience = art["fieldofscience"] != null ? art["fieldofscience"].ToString() : string.Empty;

                articles.Add(article);
            }
            return articles;
        }
    }
}
