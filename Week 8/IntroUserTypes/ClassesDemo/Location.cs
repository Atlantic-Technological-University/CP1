// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{

    public class Location
    {
        private string _locationName;

        public Location(string name) => Name = name;

        public string Name
        {
            get => _locationName;
            set => _locationName = value;
        }
    }
}
