using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Name: Fuad Mannan
 * Date: July 11, 2017
 * Description: This is the SuperHuman sub class.
 * Version: 0.2 - Added private initialize method.
 */

namespace Lesson9A
{
    /// <summary>
    /// This is the SuperHuman sub clas.
    /// It inherits from the Human Superclass.
    /// </summary>
    public class SuperHuman : Human
    {
        //Private Fields
        private List<Power> _powers;
        //Public Properties

        //Constructors
        public SuperHuman(string name) : base(name)
        {
            this._initialize();
        }

        //Private methods
        /// <summary>
        /// This method initializes and assigns default values to Class fields.
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();
        }

        //Public Methods
    }
}