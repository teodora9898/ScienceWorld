using ScienceWorld.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScienceWorld
{
    public static class Global
    {
        private static User activeUser;

        public static User ActiveUser
        {
            get { return activeUser; }
            set { activeUser = value; }
        }

        private static Article globalArticle;
        public static Article GlobalArticle
        {
            get { return globalArticle; }
            set { globalArticle = value; }
        }
    }
}
