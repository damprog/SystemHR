using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.ViewModel;
using SystemHR.DataAccessLayer.Model;
using SystemHR.DataAccessLayer.Model.Dictionaries;
using SystemHR.UserInterface.Helpers;
using SystemHR.UserInterface.Classes;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : Form
    {
        #region Fields

        private static EmployeesForm _instance = null;
        private static IList<EmployeeViewModel> fakeEmployees;

        #endregion
        #region Properties

        public static EmployeesForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeesForm();
                }
                return _instance;
            }
        }

        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }

        #endregion
        #region Constructor
        private EmployeesForm()
        {
            InitializeComponent();
            fakeEmployees = GetFakeEmployees();
            PrepareEmployeesData();
        }

        #endregion
        #region Private Methods

        private void PrepareEmployeesData()
        {
            var fakeEmployeesSorted = fakeEmployees.OrderBy(x => x.Code).ToList();
            bsEmployees.DataSource = new BindingList<EmployeeViewModel>(fakeEmployeesSorted);
            dgvEmployees.DataSource = bsEmployees;
        }

        private IList<EmployeeViewModel> GetFakeEmployees()
        {
            IList<EmployeeModel> fakeEmployeesModel = new List<EmployeeModel>()
            {
                new EmployeeModel()
                {
                   Id = 1,
                   LastName = "Andrzejewski",
                   FirstName = "Paweł",
                   Code = 1,
                   Gender = new GenderModel("mężczyzna"),
                   DateBirth = new DateTime(1994,9,1),
                   PESEL = "98346274658",
                   PhoneNumber = "343265234",
                   EmailAddress = "p.andrzejewski@gmail.com",
                   IdentityCardNumber = "AWR20443256",
                   IssueDateIdentityCard = new DateTime(2012,9,15),
                   ExpirationDateIdentityCard = new DateTime(2032,9,15),
                   PassportNumber = "ERB987678",
                   IssueDatePassport = new DateTime(2015,5,23),
                   ExpirationDatePassport = new DateTime(2025,5,23),
                   Status = new StatusModel("Wprowadzony")
                },

                new EmployeeModel()
                {
                   Id = 1,
                   LastName = "Andrzejewski",
                   FirstName = "Paweł",
                   Code = 1,
                   Gender = new GenderModel("mężczyzna"),
                   DateBirth = new DateTime(1994,9,1),
                   PESEL = "98346274658",
                   PhoneNumber = "343265234",
                   EmailAddress = "p.andrzejewski@gmail.com",
                   IdentityCardNumber = "AWR20443256",
                   IssueDateIdentityCard = new DateTime(2012,9,15),
                   ExpirationDateIdentityCard = new DateTime(2032,9,15),
                   PassportNumber = "ERB987678",
                   IssueDatePassport = new DateTime(2015,5,23),
                   ExpirationDatePassport = new DateTime(2025,5,23),
                   Status = new StatusModel("Wprowadzony")
                },

                new EmployeeModel()
                {
                   Id = 1,
                   LastName = "Andrzejewski",
                   FirstName = "Paweł",
                   Code = 1,
                   Gender = new GenderModel("mężczyzna"),
                   DateBirth = new DateTime(1994,9,1),
                   PESEL = "98346274658",
                   PhoneNumber = "343265234",
                   EmailAddress = "p.andrzejewski@gmail.com",
                   IdentityCardNumber = "AWR20443256",
                   IssueDateIdentityCard = new DateTime(2012,9,15),
                   ExpirationDateIdentityCard = new DateTime(2032,9,15),
                   PassportNumber = "ERB987678",
                   IssueDatePassport = new DateTime(2015,5,23),
                   ExpirationDatePassport = new DateTime(2025,5,23),
                   Status = new StatusModel("Wprowadzony")
                }
            };

            return MappingHelper.MapEmployeeModelToEmployeeViewModel(fakeEmployeesModel);
        }

        #endregion
        #region Events

        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmployeeAddForm frm = new EmployeeAddForm();
            frm.ReloadEmployees += (s, ea) =>
            {
                EmployeeEventArgs eventArgs = ea as EmployeeEventArgs;
                if (eventArgs != null)
                {
                    EmployeeViewModel employee
                    = MappingHelper.MapEmployeeModelToEmployeeViewModeln(eventArgs.Employee);
                    bsEmployees.Add(employee);

                    dgvEmployees.ClearSelection();
                    dgvEmployees.Rows[dgvEmployees.Rows.Count - 1].Selected = true;
                }
            };
            frm.ShowDialog();

            #endregion


        }
    }
}
