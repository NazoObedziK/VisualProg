using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class PathChangeEventArgs : EventArgs
    {
        public string Value { get; private set; }
        public PathChangeEventArgs() { }
        public PathChangeEventArgs(string path)
        {
            Value = path;
        }
    }

    public delegate void PathChangeDelegate (object sender, PathChangeEventArgs e);
}
