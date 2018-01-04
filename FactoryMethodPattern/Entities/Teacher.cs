namespace FactoryMethodPattern.Entities
{
    public class Teacher : IInformationSource
    {
        public string GiveInformation()
        {
            return "Teacher information.";
        }
    }
}
