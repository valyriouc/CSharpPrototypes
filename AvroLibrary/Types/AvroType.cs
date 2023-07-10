using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvroLibrary.Types
{

    internal enum AvroTypes
    {
        String = 0,
        Integer = 1,
        Long = 2,
        Union = 3,
        Record = 4
    }

    internal abstract class AvroType
    {
        private static Dictionary<AvroTypes, string> NameMapping = new Dictionary<AvroTypes, string>()
        {
            { AvroTypes.String, "string" },
            { AvroTypes.Integer, "int" },
            { AvroTypes.Long, "long" },
            { AvroTypes.Record, "record" },
        };

        public AvroTypes Type { get; set; }

        public string TypeName
        {
            get => NameMapping[Type];
        }        


        public AvroType(AvroTypes type)
        {
            Type = type;
        }

        public string ToJson()
        {

        }
    }
}
