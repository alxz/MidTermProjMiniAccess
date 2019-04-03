using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniAccessApp
{
    class Variables
    {
        private static string newFilePath = "";
        private static string openFilePath = "";
        private static string newTableName = "";
        private static string showTableName = "";
        private static string msgToShow = "";

        public static string OpenFilePath { get => openFilePath; set => openFilePath = value; }
        public static string NewFilePath { get => newFilePath; set => newFilePath = value; }
        public static string NewTableName { get => newTableName; set => newTableName = value; }
        public static string ShowTableName { get => showTableName; set => showTableName = value; }
    }
}
