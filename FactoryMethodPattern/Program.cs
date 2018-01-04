using System;
using FactoryMethodPattern.KnowledgeGetters;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START");

            KnowledgeGetter knowledgeGetter;

            var source = "Internet";

            switch (source)
            {
                case "Book":
                    knowledgeGetter = new BookKnowledgeGetter();
                    break;
                case "Internet":
                    knowledgeGetter = new InternetKnowledgeGetter();
                    break;
                default:
                    knowledgeGetter = new TeacherKnowledgeGetter();
                    break;
            }

            knowledgeGetter.GetKnowledge();

            Console.WriteLine("FINISH");
        }
    }
}
