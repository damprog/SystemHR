using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Model;
using SystemHR.DataAccessLayer.Model.Dictionaries;

namespace SystemHR.DataAccessLayer
{
    public class SqlConnector : IDataConnection
    {

        
            IList<EmployeeModel> fakeSqlEmployeesModel = new List<EmployeeModel>()
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
                   Id = 2,
                   LastName = "Andrzejewski",
                   FirstName = "Adam",
                   Code = 2,
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
                   Id = 3,
                   LastName = "Andrzejewski",
                   FirstName = "Marek",
                   Code = 3,
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

        public IEnumerable<EmployeeModel> GetEmployees() 
        {
            return fakeSqlEmployeesModel;
        }
        public EmployeeModel GetEmployee(int id)
        {
            return fakeSqlEmployeesModel.Single(x => x.Id == id);
        }
        public EmployeeModel CreateEmployee(EmployeeModel model)
        {
            return model;
        }
        public EmployeeModel ModifyEmployee(EmployeeModel model)
        {
            return model;
        }
        public void RemoveEmployee(int id)
        {

        }
    }
}
