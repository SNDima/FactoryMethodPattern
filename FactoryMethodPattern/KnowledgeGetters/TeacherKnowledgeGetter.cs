using FactoryMethodPattern.Entities;

namespace FactoryMethodPattern.KnowledgeGetters
{
    public class TeacherKnowledgeGetter : KnowledgeGetter
    {
        public override IInformationSource CreateSource()
        {
            return new Teacher();
        }
    }
}
