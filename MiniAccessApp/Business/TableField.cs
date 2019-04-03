using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniAccessApp.Business
{
    class TableField
    {
        //This class is for table field(s)
        private string fieldName;
        private int fieldLength;
        private string fieldType;
        private bool isPkey;
        private bool isAutoIncr;

        public string FieldName { get => fieldName; set => fieldName = value; }
        public int FieldLength { get => fieldLength; set => fieldLength = value; }
        public string FieldType { get => fieldType; set => fieldType = value; }
        public bool IsPkey { get => isPkey; set => isPkey = value; }
        public bool IsAutoIncr { get => isAutoIncr; set => isAutoIncr = value; }

        public TableField(string fieldName, int fieldLength, string fieldType, bool isPkey, bool isAutoIncr)
        {
            this.fieldName = fieldName;
            this.fieldLength = fieldLength;
            this.fieldType = fieldType;
            this.isPkey = isPkey;
            this.isAutoIncr = isAutoIncr;
        }

        public TableField()
        {
            this.fieldName = "Field1";
            this.fieldLength = 50;
            this.fieldType = "dbText";
            this.isPkey = false;
            this.isAutoIncr = false;
        }

        public static string decodeFldType(int typeCode)
        {
            string strType;
            switch (typeCode)
            {
                case 1:
                    strType = "dbBoolean";
                    break;
                case 3:
                    strType = "dbInteger";
                    break;
                case 4:
                    strType = "dbLong";
                    break;
                case 6:
                    strType = "dbSingle";
                    break;
                case 7:
                    strType = "dbDouble";
                    break;
                case 8:
                    strType = "dbDate";
                    break;
                case 10:
                    strType = "dbText";
                    break;
                case 12:
                    strType = "dbMemo";
                    break;
                default:
                    strType = "unknown";
                    break;
            }
            return strType;
        }
    }
}
