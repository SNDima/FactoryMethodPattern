using System;

namespace FactoryMethodPattern.Entities
{
    public class Book : IInformationSource
    {
        public string GiveInformation()
        {
            return "Book information.";
        }
    }
}
