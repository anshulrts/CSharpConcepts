using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class ImmutableClass
    {
        public void start()
        {
            ABC a = new ABC(1, "Test");

            // In order to make a class immutable, follow these 3 steps...
            // 1. Remove all setters from the property
            // 2. Receive all parameters in constructor
            // 3. Make all fields readonly and then return them from getters of individual property

            // Cannot call below code
            //a.Name = "Check";
        }
    }

    public class ABC
    {
        public ABC(int id, string name)
        {
            _id = id;
            _name = name;
        }

        private readonly int _id;
        private readonly string _name;

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
