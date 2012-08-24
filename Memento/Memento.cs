using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace DesignPatterns.Memento
{
    internal class Memento
    {
        private MemoryStream stream = new MemoryStream();
        private SoapFormatter formatter = new SoapFormatter();

        public Memento Serialize(object o)
        {
            formatter.Serialize(stream, o);
            return this;
        }

        public object Deserialize()
        {
            stream.Seek(0, SeekOrigin.Begin);
            object o = formatter.Deserialize(stream);
            stream.Close();
            return o;
        }
    }
}