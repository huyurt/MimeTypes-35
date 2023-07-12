using Xunit;

namespace MimeTypes35.UnitTest
{
    public class MimeTypeMap_IsExcel
    {
        [Theory]
        [InlineData("xlsx")]
        [InlineData(".xlsx")]
        [InlineData("file.xlsx")]
        public void GetMimeType_Values_ReturnTrue(string extension)
        {
            string mimeType = MimeTypeMap.GetMimeType(extension);

            Assert.True(mimeType == "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        }

        [Theory]
        [InlineData("test")]
        [InlineData(".test")]
        public void GetMimeType_Values_Equal(string extension)
        {
            string mimeType = MimeTypeMap.GetMimeType(extension);

            Assert.Equal("application/octet-stream", mimeType);
        }

        [Fact]
        public void GetExtensions_Input_NotEmpty()
        {
            var extensions = MimeTypeMap.GetExtensions("application/vnd.openxmlformats-officedocument.wordprocessingml.document");

            Assert.NotEmpty(extensions);
        }
    }
}
