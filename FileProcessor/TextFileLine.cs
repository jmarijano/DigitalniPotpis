using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessors
{
    public class TextFileLine
    {
        public string Data;

        public TextFileLine(string data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return string.Format($"{Data}");
        }
    }
}
