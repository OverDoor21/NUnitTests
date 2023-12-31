﻿
using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HTMLForamtterTests
    {
        [Test]
        public void FortmatAsBold_WhenCalled_ShouldEncloseTheString()
        {
            var formatter = new HtmlFormatter();

           var result = formatter.FormatAsBold("abc");

 /*           //Specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong").IgnoreCase);*/

            //More General
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));

        }
    }
}
