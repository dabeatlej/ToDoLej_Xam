﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ToDo.LEJ.Models;
using Xamarin.Forms;

namespace ToDo.LEJ.ViewModels
{
    public class TodoItemViewModel : ViewModel
    {
        public TodoItemViewModel(TodoItem item) => Item = item;

        public event EventHandler ItemStatusChanged;
        public TodoItem Item { get; private set; }
        public string StatusText => Item.Completed ? "Reactivate" :
        "Completed";
        public ICommand ToggleCompleted => new Command((arg) =>
        {
            Item.Completed = !Item.Completed;
            ItemStatusChanged?.Invoke(this, new EventArgs());
        });
       
    }
}
