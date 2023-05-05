using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEmployee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.AddParameter("employeeid", txtid.Text);
            dal.AddParameter("employeename", txtname.Text);
            dal.AddParameter("deduction", txtcity.Text);
            dal.AddParameter("netsalary", txtdpt.Text);
            dal.AddParameter("action", "update");
            
            dal.IsProcedureCall = true;
           

        }

        private void btnnext_Click(object sender, EventArgs e)
        {

        }
    }
}
