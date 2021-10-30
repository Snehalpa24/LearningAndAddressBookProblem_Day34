using EmployeeManagment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeePayroll
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSalaryDetails_AbleToUpdateSalaryDetails()
        {
            Salary salary = new Salary();
            SalaryUpdateModel updateModel = new SalaryUpdateModel()
            {
                SalaryId = 12,
                Month = "Jan",
                EmployeeSalary = 12000,
                EmployeeId = 123
            };

            int EmpSalary = salary.UpdateEmployeeSalary(updateModel);

            Assert.AreEqual(updateModel.EmployeeSalary, EmpSalary);

        }
    }
}