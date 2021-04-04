using Cassandra;
using ScienceWorld.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScienceWorld.Queries
{
    public static class CommentQueries
    {
        //RADI
        public static void DeleteComment(string dateadded)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;
//************************
            var isDeleted = session.Execute("delete from \"Comment\" where username = '" + Global.ActiveUser.username +
                "' and dateadded = '" + dateadded + "' and usernameforarticle ='"+Global.GlobalArticle.username+"'");


        }
        public static Comment GetCommentByDateAndUsername(string text, string dateadded)
        {

            ISession session = SessionManager.GetSession();

            if (session == null)
                return null;

            var comment = session.Execute("select * from \"Comment\" where username='" + Global.ActiveUser.username + "'" +
             "and dateadded='" + dateadded + "' and usernameforarticle='"+Global.GlobalArticle.username+"'").FirstOrDefault();

            if (comment != null)
            {
                Comment commentEntity = new Comment();

                commentEntity.text = comment["text"] != null ? comment["text"].ToString() : string.Empty;
                commentEntity.username = comment["username"] != null ? comment["username"].ToString() : string.Empty;
                // commentEntity.dateadded = comment["dateadded"] != null ? DateTime.Parse(comment["dateadded"].ToString()) : null;
                //todo Teodora : Kako da izbegnes if else i da ovo napises preko tern operatora
                string date = comment["dateadded"].ToString();
                commentEntity.dateadded = DateTime.Parse(date);

            }

            return null;
        }
        //RADI
        public static List<Comment> GetAllComments()
        {
            ISession session = SessionManager.GetSession();
         //   session.UserDefinedTypes.Define(UdtMap.For<Article>());

            if (session == null)
                return null;

            var dateaddedarticle = Global.GlobalArticle.uploaddate.ToString("yyyy-MM-dd HH':'mm':'ss");
            //todo Teodora : ovde mora da se uze u obzir i Article na koji se odnosi
            var comments = session.Execute("select * from \"Comment\" where usernameforarticle='"+Global.GlobalArticle.username+"' and uploaddatearticle = '"+ dateaddedarticle + "'");
            var allComments = new List<Comment>();

            foreach (var comment in comments)
            {
                Comment commentEnt = new Comment();
                commentEnt.username = comment["username"] != null ? comment["username"].ToString() : string.Empty;
                commentEnt.text = comment["text"] != null ? comment["text"].ToString() : string.Empty;
                commentEnt.dateadded = DateTime.Parse(comment["dateadded"].ToString());
                allComments.Add(commentEnt);
            }



            return allComments;
        }

        //RADI
        public static void AddCommentForArticle(string text)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            var dateaddedarticle =Global.GlobalArticle.uploaddate.ToString("yyyy-MM-dd HH':'mm':'ss");
            var dateadded = DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss");
            RowSet comment = session.Execute("insert into \"Comment\" (username, text, dateadded, usernameforarticle, uploaddatearticle)  values " +
                "('" + Global.ActiveUser.username + "', '" + text + "', '" + dateadded + "','"+Global.GlobalArticle.username+"','"+ dateaddedarticle + "')");
            
        }
        //RADI
        public static void UpdateComment(string dateadded, string text)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            var comment = session.Execute("update \"Comment\" " +
                          "set text = '" + text + "'" +
                          "where username='" + Global.ActiveUser.username + "'" +
                          "and dateadded='" + dateadded + "'" +
                          "and usernameforarticle='"+Global.GlobalArticle.username+"'");

        }

    }
}
