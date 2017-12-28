using System;
using System.Collections.Generic;
using System.Text;

namespace EsiOS
{
    public struct permission
    {
        public struct owner
        {
            public bool r { get;  set; }
            public bool w { get;  set; }
            public bool x { get;  set; }
        }
        public struct group
        {
            public bool r { get; set; }
            public bool w { get; set; }
            public bool x { get; set; }
        }
        public struct others
        {
            public bool r { get; set; }
            public bool w { get; set; }
            public bool x { get; set; }
        }
    }
    public class directory
    {
        public directory[] inclu;
        public directory father;
        public string owner;
        public string dirName;
        public permission DirPermission;

        public directory()
        {

        }

    }
}
