namespace PrototypePattern.Entities
{
    public interface IFigure
    {
        IFigure Clone();

        object DeepCopy();

        void GetInfo();
    }
}
