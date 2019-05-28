using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Library;

namespace Library
{
    public class validation
    {
        private string newMembName;
        public bool writeData(string details, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, true)) //// true to append data to the file
            {
                writer.WriteLine(details);
            }
            return true;
        }
       
        public bool isAddmemberNamefilledorNot(About name)
        {
            //if (name)
            //{ }
            About abt = new About();
            
            return true;
        }
    }
}