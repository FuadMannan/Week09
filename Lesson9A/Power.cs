using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson9A
{
    public class Power
    {
        //public properties
        public string Name { get; set; }
        public int Rank { get; set; }

        //constructor
        /// <summary>
        /// This is the Power constructor.
        /// Takes two parameters - name (string), rank (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }
    }
}