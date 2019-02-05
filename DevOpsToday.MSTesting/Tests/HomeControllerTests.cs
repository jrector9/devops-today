using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevOpsToday.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsToday.MSTesting.Tests
{
  [TestClass]
  public class HomeControllerTests
  {
    [TestMethod]
    public void Test_IndexAction()
    {
      var sut = new HomeController();

      Assert.IsNotNull(sut.Index());
    }
  }
}