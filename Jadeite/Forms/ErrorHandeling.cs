using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Jadeite.Forms
{
    //public partial class ErrorHandeling : Telerik.WinControls.UI.RadForm
    public partial class ErrorHandeling : Infrastructure.RadBaseForm
    {
        public ErrorHandeling()
        {
            InitializeComponent();
        }


        public void MessageError()
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = 0;

                c = a / b;
                
            }
            catch(System.IO.IOException ex)
            {
                System.Windows.Forms.MessageBox
                    .Show("پیغام خطا:" + ex.Message);
            }
            catch(System.Data.SqlClient.SqlException ex)
            {
                System.Windows.Forms.MessageBox
                    .Show("پیغام خطا:" + ex.Message);
            }

            catch(System.DivideByZeroException ex)
            {
                System.Windows.Forms.MessageBox
                    .Show("پیغام خطا:" + ex.Message);
            }

            catch(System.Exception ex)
            {
                System.Windows.Forms.MessageBox
                    .Show("پیغام خطا:" + ex.Message);
            }
            finally
            {

            }

        }

        private void ErrorHandeling_Load(object sender, EventArgs e)
        {
            MessageError();
        }
    }
}
