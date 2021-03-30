using Cassandra;
using ScienceWorld.Entities;
using System;
using System.Linq;

namespace ScienceWorld.Queries
{
    public static class UserQueries
    {
        public static void AddUser(string name, string surname, string password, string username, string email, string description, string birthday, string town)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet userData = session.Execute("insert into \"User\" (username, password, firstname, lastname," +
                " email, description, birthday, town)  values " +
                "('" + username + "', '"+ password +"', '"+ name +"', '"
                + surname +"', '"+ email +"', '"+ description +"', '"+ birthday +"', '"+ town +"')");

        }
        public static User GetUserByUsername(string username)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return null;

            User userEntity = new User();

            var user = session.Execute("select * from \"User\" where username='" + username + "'").FirstOrDefault();
            if (user != null)
            {
                userEntity.name = user["firstname"] != null ? user["firstname"].ToString() : string.Empty;
                userEntity.surname = user["lastname"] != null ? user["lastname"].ToString() : string.Empty;
                userEntity.email = user["email"] != null ? user["email"].ToString() : string.Empty;
                userEntity.username = user["username"] != null ? user["username"].ToString() : string.Empty;
                userEntity.password = user["password"] != null ? user["password"].ToString() : string.Empty;
                userEntity.description = user["description"] != null ? user["description"].ToString() : string.Empty;
                userEntity.town = user["town"] != null ? user["town"].ToString() : string.Empty;
                // userEntity.birthday = user["birthday"] != null ? user["birthday"] : string.Empty;
                string birthday = user["birthday"].ToString();
                userEntity.birthday = DateTime.Parse(birthday);
            }

            return userEntity;

        }
        public static User GetUserByUsernameAndPassword(string username, string password)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return null;

            var user = session.Execute("select * from \"User\" where username='" + username + "'" +
                "and password='"+password+"'").FirstOrDefault();
            if (user != null)
            {
                User userEntity = new User();

                userEntity.name = user["firstname"] != null ? user["firstname"].ToString() : string.Empty;
                userEntity.surname = user["lastname"] != null ? user["lastname"].ToString() : string.Empty;
                userEntity.email = user["email"] != null ? user["email"].ToString() : string.Empty;
                userEntity.username = user["username"] != null ? user["username"].ToString() : string.Empty;
                userEntity.password = user["password"] != null ? user["password"].ToString() : string.Empty;
                userEntity.description = user["description"] != null ? user["description"].ToString() : string.Empty;
                userEntity.town = user["town"] != null ? user["town"].ToString() : string.Empty;
                // userEntity.birthday = user["birthday"] != null ? user["birthday"] : string.Empty;
                string birthday = user["birthday"].ToString();
                userEntity.birthday = DateTime.Parse(birthday);

                return userEntity;
            }

            return null;

        }

        public static void UpdatePassword(string newPassword)
        {
            /*ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            var user = session.Execute("update \"User\" " +
                "set password = '"+newPassword+"'"+
                "where username='" + Global.ActiveUser.username + "'" +
                "and password='"+Global.ActiveUser.password+"'"+
                "if exists");*/
           //todo Teodora : Ne moze da se updateuje deo primarnog kljuca a password nije dobar kandidat za sekundarni indeks

        }

        public static void DeleteUsersAccount()
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet roomData = session.Execute("delete from \"User\" where username = '" + Global.ActiveUser.username +
                "' and password = '" + Global.ActiveUser.password + "'");

            //todo Teodora: na ovaj query ce da se odrazi promena iz funkcije UpdatePassword
        }
    }
}
