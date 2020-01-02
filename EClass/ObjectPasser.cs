using System.Collections.Generic;

namespace EClass
{
    public static class ObjectPasser
    {
        public static string String { get; set; }
        public static int Integer { get; set; }

        public static User UserLoggedIn { get; set; }
        public static User User { get; set; }
        public static Question Question { get; set; }

        public static List<Question> QuestionList { get; set; }

    }
}
