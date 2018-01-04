using FactoryMethodPattern.Entities;

namespace FactoryMethodPattern.KnowledgeGetters
{
    public class BookKnowledgeGetter : KnowledgeGetter
    {
        public override IInformationSource CreateSource()
        {
            return new Book();
        }
    }
}
