using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.UserInterface.Forms.Base;
using SystemHR.UserInterface.Forms.Employees.Base;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeeAddForm : BaseAddEditForm
    {
        public EmployeeAddForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        protected override void Save()
        {
            MessageBox.Show("Zapisano!");
            Close();
        }

        protected override void Cancel()
        {
            MessageBox.Show("Anulowano!");
            Close();
        }
    }
}
