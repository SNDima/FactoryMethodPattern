namespace BuilderPattern.Builders
{
    using BuilderPattern.Entities;

    public interface ITableBuilder
    {
        void Reset();

        void SetTableLegs(int legsNumber);

        void SetTableCover(TableMaterialType tableMaterialType);
    }
}
