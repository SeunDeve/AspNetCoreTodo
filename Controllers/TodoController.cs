using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Services;
using AspNetCoreTodo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTodo.Controllers
{

    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)

        {
            _todoItemService = todoItemService;
        }


        public async Task<IActionResult> Index()
        {
            var todoItems = await _todoItemService.GetIncompleteItemsAsync();

            var model = new TodoViewModel()
            {
                Items = todoItems
            };
            return View(model);

        }
    }
}

