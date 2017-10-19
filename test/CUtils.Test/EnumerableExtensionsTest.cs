using CUtils.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUtils.Test
{
    [TestFixture]
    public class EnumerableExtensionsTests
    {
        private class ListObject
        {
            public ListObject(int id)
            {
                Id = id;
            }
            public int Id { get; set; }
        }

        [Test]
        public void ForEach_PerformsActionOnEachMember()
        {
            IEnumerable<ListObject> list = new Collection<ListObject> { new ListObject(1) };
            list.ForEach(item => item.Id++);
            Assert.AreEqual(2, list.First().Id);
        }

        [Test]
        public void ForEach_NullActionThrowsArgumentException()
        {
            IEnumerable<ListObject> list = new Collection<ListObject> { new ListObject(1) };
            Assert.Throws<ArgumentNullException>(() => list.ForEach(null));
        }

        [Test]
        public void ForEach_PerformsActionOnMultipleMembers()
        {
            IEnumerable<ListObject> list = new Collection<ListObject> { new ListObject(1), new ListObject(2) };
            list.ForEach(item => item.Id++);
            Assert.AreEqual(2, list.First().Id);
            Assert.AreEqual(3, list.Last().Id);
        }
    }
}
