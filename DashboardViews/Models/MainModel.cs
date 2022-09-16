using DashboardViews.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DashboardViews.Models
{
    public class MenuItem
    {
        public MenuItem(ICommand _command = null)
        {
            CommandButton = _command;
        }
        public string Title { get; set; }
        public string Image { get; set; }
        public ICommand CommandButton { get; set; } 

    }
}
