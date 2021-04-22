using AutoMapper;
using BusinessLogic;
using NUnit.Framework;
using Moq;
using DataAccess;

namespace Tests
{
    public class EmployeeFactoryTest
    {
        private EmployeeFactory _employeeFactory;
        private Mock<IMapper> _mapperMock;

        [SetUp]
        public void Setup()
        {
            _mapperMock = new Mock<IMapper>();
            _employeeFactory = new EmployeeFactory(_mapperMock.Object);

            _mapperMock.Setup(m => m.Map<EmployeeHourly>(It.IsAny<EmployeeRaw>())).Returns(new EmployeeHourly());
            _mapperMock.Setup(m => m.Map<EmployeeMonthly>(It.IsAny<EmployeeRaw>())).Returns(new EmployeeMonthly());
        }

        [Test]
        public void GetEmployee_ContractTypeHourlySalaryEmployee_ReturnEmployeeHourly()
        {
            // Arrange
            var employeeRaw = new EmployeeRaw();
            employeeRaw.contractTypeName = "HourlySalaryEmployee";

            // Act
            var employee = _employeeFactory.GetEmployee(employeeRaw);

            // Assert
            Assert.IsInstanceOf(typeof(EmployeeHourly), employee);
        }

        [Test]
        public void GetEmployee_ContractTypeMonthlySalaryEmployee_ReturnEmployeeMonthly()
        {
            // Arrange
            var employeeRaw = new EmployeeRaw();
            employeeRaw.contractTypeName = "MonthlySalaryEmployee";

            // Act
            var employee = _employeeFactory.GetEmployee(employeeRaw);

            // Assert
            Assert.IsInstanceOf(typeof(EmployeeMonthly), employee);
        }
    }
}