
using System.ComponentModel.DataAnnotations;
using EconomicManagementAPP.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EconomicManagementAPP.Test
{
    [TestClass]
    public class FirstCapitalLetterTest
    {
        [TestMethod]
        public void FirstLetterLower_ReturnError()
        {
            var firstCapitalLetter = new FirstCapitalLetter();
            var data = "tarjeta";

            var context = new ValidationContext(new { Name = data });

            var testResult = firstCapitalLetter.GetValidationResult(data, context);
            Assert.AreEqual("The first letter must be in uppercase", testResult?.ErrorMessage);
        }

        [TestMethod]
        public void FirstLetterLower_isNull()
        {
            var firstCapitalLetter = new FirstCapitalLetter();
            string data = null;

            var context = new ValidationContext(new { Name = data });

            var testResult = firstCapitalLetter.GetValidationResult(data, context);
            Assert.IsNull(testResult);
        }

    }

}
