using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvaluationSampleCode;
using System.Collections.Generic;

namespace EvaluationSampleCodeTests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        [TestMethod]
        public void GetStrongFormat_ReturnsStrongFormattedString()
        {
            // Arrange
            var helper = new HtmlFormatHelper();
            var content = "test";

            // Act
            var result = helper.GetStrongFormat(content);

            // Assert
            Assert.AreEqual("<strong>test</strong>", result);
        }

        [TestMethod]
        public void GetItalicFormat_ReturnsItalicFormattedString()
        {
            // Arrange
            var helper = new HtmlFormatHelper();
            var content = "test";

            // Act
            var result = helper.GetItalicFormat(content);

            // Assert
            Assert.AreEqual("<i>test</i>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_ReturnsCorrectHtmlList()
        {
            // Arrange
            var helper = new HtmlFormatHelper();
            var contents = new List<string> { "item1", "item2" };

            // Act
            var result = helper.GetFormattedListElements(contents);

            // Assert
            var expectedHtml = "<ul><li>item1</li><li>item2</li></ul>";
            Assert.AreEqual(expectedHtml, result);
        }

        [TestMethod]
        public void GetFormattedListElements_EmptyList_ReturnsOnlyUlTags()
        {
            // Arrange
            var helper = new HtmlFormatHelper();
            var contents = new List<string>(); 

            // Act
            var result = helper.GetFormattedListElements(contents);

            // Assert
            Assert.AreEqual("<ul></ul>", result);
        }
    }
}
