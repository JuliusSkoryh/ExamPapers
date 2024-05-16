using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePaper
{
    public record Note
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int[] DateOfBirth{ get; set; } = new int[3];


        public Note(string firstName, string lastName, string phoneNumber, int[] dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;

            if(dateOfBirth.Length == 3)
            {
                DateOfBirth = dateOfBirth;
            }
        }

    }
}
