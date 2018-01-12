using System.Runtime.Serialization;

namespace PrototypePattern.Entities
{
    using System;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    [Serializable]
    public class Circle : IFigure
    {
        private int _radius;

        public Point Point { get; set; }

        public Circle(int r, int x, int y)
        {
            _radius = r;
            Point = new Point {X = x, Y = y};
        }

        public IFigure Clone()
        {
            return this.MemberwiseClone() as IFigure;
        }

        public object DeepCopy()
        {
            object figure = null;
            using (MemoryStream tempStream = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter(
                    null, new StreamingContext(StreamingContextStates.Clone));

                binaryFormatter.Serialize(tempStream, this);
                tempStream.Seek(0, SeekOrigin.Begin);

                figure = binaryFormatter.Deserialize(tempStream);
            }
            return figure;
        }

        public void GetInfo()
        {
            Console.WriteLine("Radius {0} and the Point ({1}, {2})", _radius, Point.X, Point.Y);
        }
    }
}
