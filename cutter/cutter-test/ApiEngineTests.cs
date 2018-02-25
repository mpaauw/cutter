using cutter.Engine;
using cutter.Types;
using cutter.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cutter_test
{
    [TestClass]
    public class ApiEngineTests
    {
        private const int SAMPLE_STORY_ID = 8863;
        private const int SAMPLE_ASK_ID = 121003;
        private const int SAMPLE_COMMENT_ID = 2921983;
        private const int SAMPLE_JOB_ID = 192327;
        private const int SAMPLE_POLL_ID = 126809;
        private const int SAMPLE_POLLOPT_ID = 160705;
        private const string SAMPLE_USER_ID = "jl";

        private ApiEngine engine = new ApiEngine();
        private List<Item> topItems = new List<Item>();
        private const int UPPER_BOUND_SIZE = 500;

        [TestInitialize]
        public void TestInitialize()
        {
        }

        [TestMethod]
        public void GetItemByTypeStoryTest()
        {
            var expected1 = typeof(Story);
            string expected2 = Constants.ITEM_TYPE_STORY;
            var item = this.engine.GetItemByType<Story>(SAMPLE_STORY_ID);
            var actual1 = item.GetType();
            string actual2 = item.type;
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void GetItemByTypeAskTest()
        {
            var expected1 = typeof(Ask);
            string expected2 = Constants.ITEM_TYPE_STORY;
            var item = this.engine.GetItemByType<Ask>(SAMPLE_ASK_ID);
            var actual1 = item.GetType();
            string actual2 = item.type;
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.IsNotNull(item.text);
        }

        [TestMethod]
        public void GetItemByTypeCommentTest()
        {
            var expected1 = typeof(Comment);
            string expected2 = Constants.ITEM_TYPE_COMMENT;
            var item = this.engine.GetItemByType<Comment>(SAMPLE_COMMENT_ID);
            var actual1 = item.GetType();
            string actual2 = item.type;
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void GetItemByTypeJobTest()
        {
            var expected1 = typeof(Job);
            string expected2 = Constants.ITEM_TYPE_JOB;
            var item = this.engine.GetItemByType<Job>(SAMPLE_JOB_ID);
            var actual1 = item.GetType();
            string actual2 = item.type;
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void GetItemByTypePollTest()
        {
            var expected1 = typeof(Poll);
            string expected2 = Constants.ITEM_TYPE_POLL;
            var item = this.engine.GetItemByType<Poll>(SAMPLE_POLL_ID);
            var actual1 = item.GetType();
            string actual2 = item.type;
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void GetItemByTypePolloptTest()
        {
            var expected1 = typeof(Pollopt);
            string expected2 = Constants.ITEM_TYPE_POLLOPT;
            var item = this.engine.GetItemByType<Pollopt>(SAMPLE_POLLOPT_ID);
            var actual1 = item.GetType();
            string actual2 = item.type;
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void GetUserTypeTest()
        {
            var expected = typeof(User);
            var user = this.engine.GetUser(SAMPLE_USER_ID);
            var actual = user.GetType();
            Assert.AreEqual(expected, actual);
        }
    }
}
