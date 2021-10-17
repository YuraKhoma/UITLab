using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using WebShop.BL.Abstractions;
using WebShop.Common.Models;
using WebShop.DataAccess.Abstractions;

namespace WebShop.BL.Tests
{
    [TestClass]
    public class ItemManagerTests
    {
        private ItemManager itemManager;
        private Mock<IItemRepository> itemRepositoryMock;
        private Mock<IItemManager> itemManagerMock;

        [TestInitialize]
        public void Init()
        {
            itemRepositoryMock = new Mock<IItemRepository>();
            itemManager = new ItemManager(itemRepositoryMock.Object);

            itemManagerMock = new Mock<IItemManager>();
        }

        [TestMethod]
        public void GetItemList_ItemsExist_ReturnsItems()
        {
            var items = new List<Item>
            {
                new Item
                {
                    Title = "test2",
                    Price = 1234,
                    Category = ItemCategory.Phone
                },
                new Item
                {
                    Title = "test2232",
                    Price = 42,
                    Category = ItemCategory.TV
                },
            };

            itemRepositoryMock.Setup(x => x.GetNewItems()).Returns(items);

            var receivedUsers = itemManager.GetItemsList();

            Assert.AreEqual(items, receivedUsers);
        }

        [TestMethod]
        public void GetItemsListUsers_UserNotExists_ReturnsNull()
        {
            itemRepositoryMock.Setup(x => x.GetNewItems());

            var receivedUsers = itemManager.GetItemsList();

            Assert.AreEqual(null, receivedUsers);
        }

        [TestMethod]
        public void FinsItemByName_NameEsisysts_ReturnsItem()
        {
            var items = new List<Item>()
            {
                new Item
                {
                    Title = "tesdas"
                },

                new Item
                {
                    Title = "test1"
                },
            };

            itemRepositoryMock.Setup(x => x.GetNewItems()).Returns(items);

            var receivedUsers = itemManager.FindByName("test1");

            Assert.AreEqual("test1", receivedUsers.Title);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void FinsItemByName_NameNotExists_ReturnsNullReferenceException()
        {
            var items = new List<Item>()
            {
                new Item
                {
                    Title = "tesdas"
                },

                new Item
                {
                    Title = "test1"
                },
            };

            itemRepositoryMock.Setup(x => x.GetNewItems()).Returns(items);

            var receivedUsers = itemManager.FindByName("test2");

            Assert.AreEqual(null, receivedUsers.Title);
        }
    }
}
