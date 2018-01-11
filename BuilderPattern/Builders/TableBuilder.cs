namespace BuilderPattern.Builders
{
    using BuilderPattern.Entities;

    public class TableBuilder : ITableBuilder
    {
        private Table _table;

        public void Reset()
        {
            _table = new Table();
        }

        public void SetTableLegs(int legsNumber)
        {
            _table.LegsNumber = legsNumber;
        }

        public void SetTableCover(TableMaterialType tableMaterialType)
        {
            _table.Cover = tableMaterialType;
        }

        public Table GetResult()
        {
            return _table;
        }
    }
}
