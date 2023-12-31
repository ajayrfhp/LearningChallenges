using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatasetChallenge
{
    public class UserModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public bool IsAlive { get; set; }

        public UserModel() { }

        public override string ToString()
        {
            
            return this.FirstName + ":" + this.LastName + ":" + this.Age;
        }

    }
}
