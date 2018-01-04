using System;
using FactoryMethodPattern.Entities;

namespace FactoryMethodPattern.KnowledgeGetters
{
    public abstract class KnowledgeGetter
    {
        public void GetKnowledge()
        {
            var source = CreateSource();
            var information = source.GiveInformation();

            Console.WriteLine("INFORMATION: " + information);

            AnalyzeInformation();
            ObtainKnowledge();
        }

        public abstract IInformationSource CreateSource();

        private void AnalyzeInformation()
        {
            Console.WriteLine("The information was analyzed.");
        }

        private void ObtainKnowledge()
        {
            Console.WriteLine("Knowledge was obtained.");
        }
    }
}
