namespace BuilderPattern.Builders
{
    using BuilderPattern.Entities;

    public class TablePictureBuilder : ITableBuilder
    {
        private TablePicture _tablePicture;

        public void Reset()
        {
            _tablePicture = new TablePicture();
        }

        public void SetTableLegs(int legsNumber)
        {
            _tablePicture.LegsNumber = legsNumber;
        }

        public void SetTableCover(TableMaterialType tableMaterialType)
        {
            _tablePicture.Cover = tableMaterialType;
        }

        public TablePicture GetResult()
        {
            return _tablePicture;
        }
    }
}
