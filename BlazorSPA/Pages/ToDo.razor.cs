using BlazorSPA.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSPA.Pages
{
    public class ToDoBase : ComponentBase
    {
        protected IList<ToDoItem> todos = new List<ToDoItem>();
        protected string newTodo;

        protected void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                todos.Add(new ToDoItem { Title = newTodo });
                newTodo = string.Empty;
            }
        }
    }
}
