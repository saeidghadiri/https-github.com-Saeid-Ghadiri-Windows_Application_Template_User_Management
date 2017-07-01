using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Models
{
    public class BaseEntity : object
    {
        public BaseEntity() : base()
        {
            Id = System.Guid.NewGuid();
        }

        // **********
        // Defualt All the Tables
        public System.Guid Id { get; set; }
        // **********
    }
}
