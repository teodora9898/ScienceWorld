using Cassandra;
using System;

namespace ScienceWorld.Queries
{
    public static class UserQueries
    {
        public static void AddUser(string name, string surname, string password, string username, string email, string description, string birthday, string town)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet hotelData = session.Execute("insert into \"User\" (username, password, firstname, lastname, email, description, birthday, town)  values ('" + username + "', '"+ password +"', '"+ name +"', '"+ surname +"', '"+ email +"', '"+ description +"', '"+ birthday +"', '"+ town +"')");

        }
    }
}
