using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable]
    public class BinaryObject
    {
        public int Operation { get; set; }

        public string Type { get; set; }

        public object Data { get; set; }

        public BinaryObject(int operation, object data)
        {
            Operation = operation;
            Data = data;
            Type = "Not Set";
        }

        public BinaryObject(int operation, string type, object data)
            : this(operation, data)
        {
            Type = type;
        }

    }
}
