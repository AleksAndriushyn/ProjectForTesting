using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileChecking
{
    public class File
    {
        public string Name { get; set; }
        public int VersionId = 0;

        public File(string name)
        {
            var splittedName = name.Split('_');
            Name = name.Split('.')[0];
            if (splittedName.Length > 1)
                VersionId = Int32.Parse(splittedName[1].Split('.')[0]);
        }
    }
}
