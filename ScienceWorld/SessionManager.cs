﻿using Cassandra;

namespace ScienceWorld
{
    public static class SessionManager
    {
        public static ISession session;

        public static ISession GetSession()
        {
            if (session == null)
            {
                Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
                session = cluster.Connect("ScienceWorld");
            }
            return session;
        }
    }
}


//insert into "Hotel" ("hotelID", address, city, name, phone, state, zip)  values ('1', 'Vozda Karadjordja 1', 'Nis', 'Ambasador', '123', 'Srbija', '18000');
//select * from "Hotel" where "hotelID"='1'