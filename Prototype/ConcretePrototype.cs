using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatterns.Prototype
{
    [Serializable]
    internal class ConcretePrototype : ICloneable
    {
        public object PropertyA { get; set; }

        public object PropertyB { get; set; }

        public object Clone(bool shallow)
        {
            return shallow ? Clone() : DeepCopy();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public object DeepCopy()
        {
            var stream = new MemoryStream();
            var formatter = new BinaryFormatter();

            formatter.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);

            object copy = formatter.Deserialize(stream);
            stream.Close();
            return copy;
        }
    }
}