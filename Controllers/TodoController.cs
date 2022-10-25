using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Services;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreTodo.Models;


namespace AspNetCoreTodo.Controllers
{

    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)

        {
            _todoItemService = todoItemService;
        }

    }

    public IActionResult Index()
    {
       // Get to-do item from database

        // Put items into a model

        // pass the view to a model and render
    }
}

