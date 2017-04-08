using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp.Model;
using WpfApp.ViewModel;

namespace LibTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_CreateEmptyRepository()
        {
            var repo = new Repository();
            Assert.IsNotNull(repo);
            Assert.IsNotNull(repo.Albums);
            Assert.AreEqual(0, repo.Albums.Count);
        }

        [TestMethod]
        public void Test_CreateNewAlbum()
        {
            var album = new Album();
            Assert.IsNotNull(album);
        }

        [TestMethod]
        public void Test_FormattedSongLength()
        {
            var song = new Song { Length = TimeSpan.FromMinutes(3.5) };
            var songVM = new SongViewModel(song);
            Assert.AreEqual("03:30", songVM.FormattedLength);
        }

        [TestMethod]
        public void Test_SetFormattedSongLength()
        {
            var song = new Song { Length = TimeSpan.FromMinutes(0.0) };
            var songVM = new SongViewModel(song);
            songVM.FormattedLength = "03:30";
            Assert.AreEqual("03:30", songVM.FormattedLength);
        }

                [TestMethod]
        public void Test_FAIL()
        {
            Assert.Fail();
        }
    }
}
