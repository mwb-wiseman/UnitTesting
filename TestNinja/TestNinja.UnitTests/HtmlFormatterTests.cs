using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            // Specific assertio. Will break each time we change the slightest aspect
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase); // .IgnoreCase makes the assertion no longer case-sensitive (which is default)

            // More general - when checking strings usually best to be a bit more general
            // Assert.That(result, Does.StartWith("<strong>"));
            // Assert.That(result, Does.EndWith("</strong>"));
            // Assert.That(result, Does.Contain("abc"));
        }
    }
}
