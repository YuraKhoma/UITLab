using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebShop.Common.Models;
using WebShop.DataAccess.Abstractions;

namespace WebShop.BL.Tests
{
    [TestClass]
    public class AuthorizationManagerTests
    {
        private AuthorizationManager authorizationManager;
        private Mock<IUserRepository> userRepositoryMock;

        [TestInitialize]
        public void Init()
        {
            userRepositoryMock = new Mock<IUserRepository>();
            authorizationManager = new AuthorizationManager(userRepositoryMock.Object);
        }

        [TestMethod]
        public void RegisterUser_LoginAlreadyUsed_ReturnsFalse()
        {
            var login = "testLogin";
            var password = "testPassword";

            var user = new User
            {
                Login = login,
                Password = password,
                Role = UserRole.Guest
            };

            userRepositoryMock.Setup(x => x.GetUserByLogin(login)).Returns(user);

            var isUserRegistered = authorizationManager.RegisterUser(user);

            Assert.IsFalse(isUserRegistered);
        }

        [TestMethod]
        public void RegisterUser_UserRoleIsNotGuest_ReturnsFalse()
        {
            var login = "testLogin";
            var password = "testPassword";

            var user = new User
            {
                Login = login,
                Password = password,
                Role = UserRole.User
            };

            User userInDb = null;
            userRepositoryMock.Setup(x => x.GetUserByLogin(login)).Returns(userInDb);

            var isUserRegistered = authorizationManager.RegisterUser(user);

            Assert.IsFalse(isUserRegistered);
        }

        [TestMethod]
        public void RegisterUser_LoginNotExistsAndUserIsGuest_ReturnsTrue()
        {
            var login = "testLogin";
            var password = "testPassword";

            var user = new User
            {
                Login = login,
                Password = password,
                Role = UserRole.Guest
            };

            User userInDb = null;
            userRepositoryMock.Setup(x => x.GetUserByLogin(login)).Returns(userInDb);

            var isUserRegistered = authorizationManager.RegisterUser(user);

            Assert.IsTrue(isUserRegistered);
        }

        [TestMethod]
        public void RegisterUser_LoginNotExistsAndUserIsGuest_CreateMethodIsCalled()
        {
            var login = "testLogin";
            var password = "testPassword";

            var user = new User
            {
                Login = login,
                Password = password,
                Role = UserRole.Guest
            };

            User userInDb = null;
            userRepositoryMock.Setup(x => x.GetUserByLogin(login)).Returns(userInDb);

            authorizationManager.RegisterUser(user);

            userRepositoryMock.Verify(x => x.Create(
                It.Is<User>(x =>
                    x.Login == login && x.Password == password && x.Role == UserRole.User)));
        }
    }
}
