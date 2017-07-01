using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Infrastructure
{
    public partial class RadBaseForm : Telerik.WinControls.UI.RadForm
    {
        public RadBaseForm()
        {
            InitializeComponent();
        }

        private void RadBaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
