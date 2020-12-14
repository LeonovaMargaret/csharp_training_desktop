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
            int removalIndex = 1;

            if (!app.Groups.IsGroupExist(removalIndex))
            {
                GroupData group = new GroupData() { Name = "Test123" };
                app.Groups.Add(group);
            }

            List<GroupData> oldGroups = app.Groups.GetList();

            app.Groups.Remove(removalIndex);

            List<GroupData> newGroups = app.Groups.GetList();
            oldGroups.RemoveAt(removalIndex);
            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
