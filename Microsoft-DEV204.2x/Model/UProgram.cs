using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class UProgram
    {
        public Degree Degree { get; set; }
        public readonly string Title;

        public UProgram(string title)
        {
            Title = title;
        }


    }
}
