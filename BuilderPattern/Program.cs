namespace BuilderPattern
{
    using BuilderPattern.Builders;
    using BuilderPattern.Directors;

    class Program
    {
        static void Main(string[] args)
        {
            var director = new TableDirector();

            var tableBuilder = new TableBuilder();
            director.ConsructWoodenTable(tableBuilder);
            var table = tableBuilder.GetResult();

            var tablePictureBuilder = new TablePictureBuilder();
            director.ConsructWoodenTable(tablePictureBuilder);
            var tablePicture = tablePictureBuilder.GetResult();
        }
    }
}
