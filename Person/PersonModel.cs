using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    /// <summary>
    /// Person model
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }

        public string Title { get; set; }

        public PersonModel() 
        { 
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
        }

        public PersonModel(string firstName, string lastName) 
        { 
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public PersonModel(PersonModel otherPerson) 
        { 
            this.FirstName = otherPerson.FirstName;
            this.LastName = otherPerson.LastName;
        }

        /// <summary>
        /// Display object
        /// </summary>
        public void DisplayObject()
        {
            Console.WriteLine("{0} {1}", this.FirstName, this.LastName);   
        }

        public PersonModel? Clone()
        {
            return new PersonModel(this.FirstName, this.LastName);
        }

    }
}
