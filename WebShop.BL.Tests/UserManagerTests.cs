using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using WebShop.Common.Models;
using WebShop.DataAccess.Abstractions;

namespace WebShop.BL.Tests
{
    [TestClass]
    public class UserManagerTests
    {
        private UserManager userManager;
        private Mock<IUserRepository> userRepositoryMock;

        [TestInitialize]
        public void Init()
        {
            userRepositoryMock = new Mock<IUserRepository>();
            userManager = new UserManager(userRepositoryMock.Object);
        }

        [TestMethod]
        public void GetAllUsers_UsersExist_ReturnsUsers()
        {
            var users = new List<User>
            {
                new User
                {
                    Login = "test2",
                    Password = "p12",
                    Role = UserRole.Guest
                },
                new User
                {
                    Login = "test22",
                    Password = "p123",
                    Role = UserRole.Guest
                },
            };

            userRepositoryMock.Setup(x => x.GetUsers()).Returns(users);

            var receivedUsers = userManager.GetAllUsers();
            
            Assert.AreEqual(users, receivedUsers);
        }

        [TestMethod]
        public void GetAllUsers_UserNotExists_ReturnsNull()
        {
            userRepositoryMock.Setup(x => x.GetUsers());

            var receivedUsers = userManager.GetAllUsers();

            Assert.AreEqual(null, receivedUsers);
        }
    }
}
