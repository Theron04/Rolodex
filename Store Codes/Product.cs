using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Codes
{
    internal class Product
    {
        private string name;
        private int code;

        public Product(string name, int code)
        {
            this.name = name;
            this.code = code;
        }

        public string GetName() { return name; }
        public int GetCode() { return code; }

        public string ToString()
        {
            string result = String.Format(name, $"{',', 30}", code);
            return result;
        }
    }
}
