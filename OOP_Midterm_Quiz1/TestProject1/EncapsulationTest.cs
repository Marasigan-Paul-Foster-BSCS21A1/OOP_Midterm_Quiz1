using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using static ClassLibrary1.BankAccount;

[TestClass]
public class EncapsulationTests
{
    // 1. Test for private field access
    [TestMethod]
    public void TestBalanceDirectAccess()
    {
        BankAccount account = new BankAccount("Savings", 500);
         account.GetBalance();  // Should not be accessible directly
        Assert.AreEqual(1000, account.GetBalance());
    }

    // 2. Test for restricted account name change
    [TestMethod]
    public void TestAccountNameChange()
    {
        BankAccount account = new BankAccount("Savings", 500);
        account.AccountName = "Pete";  // Should be restricted or validated
        Assert.AreEqual("Pete", account.AccountName);
    }

    // 3. Test for depositing negative amount
    [TestMethod]
    public void TestNegativeDeposit()
    {
        BankAccount account = new BankAccount("Savings", 500);
        account.Deposit(-200);  // Should not allow negative deposit
        Assert.AreEqual(500, account.GetBalance());
    }

    // 4. Test for withdrawing amount greater than balance
    [TestMethod]
    public void TestOverdraw()
    {
        BankAccount account = new BankAccount("Savings", 500);
        account.Withdraw(600);  // Should not allow overdraw
        Assert.AreEqual(500, account.GetBalance());
    }

    // 5. Test for accessing protected member directly
    [TestMethod]
    public void TestProtectedEmployeeIdAccess()
    {
        Employee emp = new Employee("E001");
        emp.GetEmployeeId();  // Should not be accessible directly
        Assert.AreEqual("E001", emp.GetEmployeeId());
    }

    // 6. Test for modifying age to an invalid value
    [TestMethod]
    public void TestInvalidAge()
    {
        Customer customer = new Customer("John Doe", 25);
        customer.Age = -5;  // Should not allow negative age
        Assert.AreEqual(25, customer.Age);
    }

    // 7. Test for modifying private field in Manager class
    [TestMethod]
    public void TestModifyEmployeeIdInManager()
    {
        Manager manager = new Manager("M001", "HR");
        manager._employeeId = "M002";  // Should not be accessible directly
        Assert.AreEqual("M002", manager.GetEmployeeId());
    }

    // 8. Test for empty account name
    [TestMethod]
    public void TestEmptyAccountName()
    {
        BankAccount account = new BankAccount("", 500);  // Should not allow empty account name
        Assert.IsTrue(string.IsNullOrEmpty(account.AccountName));
    }

    // 9. Test for null account name
    [TestMethod]
    public void TestNullAccountName()
    {
        BankAccount account = new BankAccount(null, 500);  // Should not allow null account name
        Assert.IsNull(account.AccountName);
    }

    // 10. Test for withdrawing zero amount
    [TestMethod]
    public void TestZeroWithdraw()
    {
        BankAccount account = new BankAccount("Savings", 500);
        account.Withdraw(0);  // Should not allow zero withdrawal
        Assert.AreEqual(500, account.GetBalance());
    }

    // 11. Test for accessing private field in Customer
    [TestMethod]
    public void TestAccessPrivateNameField()
    {
        Customer customer = new Customer("John Doe", 25);
        customer._name = "Jane Doe";  // Should not be accessible directly
        Assert.AreEqual("Jane Doe", customer.Name);
    }

    // 12. Test for setting null name in Customer
    [TestMethod]
    public void TestSetNullName()
    {
        Customer customer = new Customer("John Doe", 25);
        customer.Name = null;  // Should not allow null name
        Assert.IsNull(customer.Name);
    }

    // 13. Test for accessing protected member from unrelated class
    [TestMethod]
    public void TestAccessProtectedEmployeeId()
    {
        Customer customer = new Customer("John Doe", 25);
        customer._employeeId = "C001";  // Should not be accessible
        Assert.IsNull(customer.GetEmployeeId());
    }

    // 14. Test for setting age above logical limit
    [TestMethod]
    public void TestSetAgeAboveLimit()
    {
        Customer customer = new Customer("John Doe", 25);
        customer.Age = 200;  // Should restrict age to a reasonable range
        Assert.AreEqual(25, customer.Age);
    }

    // 15. Test for setting department in manager
    [TestMethod]
    public void TestSetNullDepartment()
    {
        Manager manager = new Manager("M001", "HR");
        manager.Department = null;  // Should not allow null department
        Assert.IsNull(manager.Department);
    }
}
