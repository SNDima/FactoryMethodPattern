namespace FactoryMethodPattern.Entities
{
    public class Internet : IInformationSource
    {
        public string GiveInformation()
        {
            return "Internet information.";
        }
    }
}
