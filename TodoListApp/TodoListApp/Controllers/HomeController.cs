using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TodoListApp.AppLogic;
using TodoListApp.Models;
using TodoListApp.UI.Models;

namespace TodoListApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TodoListService _todoListService;
        public HomeController(TodoListService todoService, ILogger<HomeController> logger)
        {
            _logger = logger;
            _todoListService = todoService;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            _logger.LogDebug($"{nameof(Index)} has been called");
            var viewModel = new TodoListHomeViewModel
            {
                TodoLists = await _todoListService.GetUserListsAsync("1", cancellationToken)
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            try
            {
                //application logic
            }
            catch (Exception ex)
            {
                _logger.LogError($"There is a problem processing the request: {ex.Message}");
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
