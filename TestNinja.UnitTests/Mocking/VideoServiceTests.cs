using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mock
{
    [TestFixture]
    public class VideoServiceTests
    {

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnErrormesage()
        {
            var mFileReader = new Mock<IFileReader>();
            var _videoService = new VideoService(mFileReader.Object);
            mFileReader.Setup(fr => fr.Read("video.txt")).Returns("");
          

            var result = _videoService.ReadVideoTitle();
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
  