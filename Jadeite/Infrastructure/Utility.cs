using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class Utility
    {
        static Utility()
        { }

        public static Models.User AuthenticatedUser { get; set; }
    }
}
