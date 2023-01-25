using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Vectors.Entities
{
    internal class Tenant
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int RoomNumber { get; set; }

        public Tenant(string name, string email, int roomNumber)
        {
            Name = name;
            Email = email;
            RoomNumber = roomNumber;
        }

        public override string ToString()
        {
            return "Room: " + RoomNumber + " -> " + Name + ", " + Email + ";";
        }

    }
}
