﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Name: Fuad Mannan
 * Date: July 11, 2017
 * Description: This is the SuperHuman sub class.
 * Version: 0.3 - Added public AddPower method.
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
        public List<Power> Powers
        {
            get
            {
                return this._powers; //returns a reference to the Powers list
            }
        }
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
        /// <summary>
        /// This adds a power to _powers
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
    }
}