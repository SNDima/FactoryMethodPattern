namespace BuilderPattern.Directors
{
    using BuilderPattern.Builders;
    using BuilderPattern.Entities;

    public class TableDirector
    {
        public void ConsructWoodenTable(ITableBuilder builder)
        {
            builder.Reset();
            builder.SetTableLegs(4);
            builder.SetTableCover(TableMaterialType.Wood);
        }
    }
}
