using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [System.AttributeUsage(System.AttributeTargets.All)]
    public sealed class PartialPathAttribute : Attribute
    {
        private readonly string path;

        public string Path
        {
            get { return path; }
        }

        public PartialPathAttribute(string path)
        {
            this.path = path;
        }
    }
}
