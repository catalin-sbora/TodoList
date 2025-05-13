using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApp.AppLogic;
using TodoListApp.UnitTests.DummyImplementation;

namespace TodoListApp.UnitTests
{
    [TestClass]
    public sealed class TodoListServiceTest
    {

        [TestMethod]
        public async Task GetUserLists_Returns_Only_List_For_Current_User()
        {
            //Arrange
            TodoListService todoService = new TodoListService(new TodoListRepositoryFakeImplementation());
            //Act
            var usersList = await todoService.GetUserListsAsync("1", CancellationToken.None);

            //Assert
            Assert.AreEqual(1, usersList.Count());
            Assert.AreEqual("1", usersList.ElementAt(0).Owner);
        }
    }
}
