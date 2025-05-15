
using TodoListApp.AppLogic;
using TodoListApp.UnitTests.DummyImplementation;

namespace TodoListApp.UnitTests
{
    [TestClass]
    public sealed class TodoListServiceTest
    {

        [TestMethod]
        public void GetUserLists_Returns_Only_List_For_Current_User()
        {
            //Arrange
            TodoListService todoService = new TodoListService(new TodoListRepositoryFakeImplementation());
            //Act
            var usersList = todoService.GetUserListsAsync("2", CancellationToken.None)
                                       .Result;                     
                                       

            //Assert
            Assert.AreEqual(1, usersList.Count());
            Assert.AreEqual("2", usersList.ElementAt(0).Owner);
        }

        [TestMethod]
        public async Task GetUserLists_Throws_ArgumentException_When_UserId_Is_Invalid()
        {
            //Arrange
            TodoListService todoService = new TodoListService(new TodoListRepositoryFakeImplementation());
            //Act

            await Assert.ThrowsExceptionAsync<ArgumentException>(() => todoService.GetUserListsAsync("1", CancellationToken.None));
            
        }

    }
}
