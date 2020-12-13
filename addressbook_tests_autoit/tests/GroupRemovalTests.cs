using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void TestGroupRemoval()
        {
            List<GroupData> oldGroups = app.Groups.GetList();

            int removalIndex = 1;
            app.Groups.Remove(removalIndex);

            List<GroupData> newGroups = app.Groups.GetList();
            oldGroups.RemoveAt(removalIndex);
            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
