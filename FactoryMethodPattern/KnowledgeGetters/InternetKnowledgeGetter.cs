using FactoryMethodPattern.Entities;

namespace FactoryMethodPattern.KnowledgeGetters
{
    public class InternetKnowledgeGetter : KnowledgeGetter
    {
        public override IInformationSource CreateSource()
        {
            return new Internet();
        }
    }
}
