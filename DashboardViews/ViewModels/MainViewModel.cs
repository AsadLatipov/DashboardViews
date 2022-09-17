using Caliburn.Micro;
using DashboardViews.Commands;
using DashboardViews.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace DashboardViews.ViewModels
{
    public class MainViewModel : Conductor<object>
    {

        public ICommand DragWindow { get; set; }
        public ICommand Exit { get; set; }
        public ICommand Search { get; set; }
        public ICommand MenuItemsClick { get; set; }


        public MainViewModel()
        {
            RightSideElements = new RightSideItemsViewModels();
           

            DragWindow = new CommandBase(ExecuteDrag, CanExecuteDrag);
            Exit = new CommandBase(ExecuteExit, CanExecuteExit);
            Search = new CommandBase(ExecuteSearch, CanExecuteSearch);
            MenuItemsClick = new CommandBase(ExecuteMenuItemsClick, CanExecuteMenuItemsClick);


            MenuItems.AddRange(new List<MenuItem> {
                new MenuItem(MenuItemsClick) { Title = "Home", Image = "../assets/home.png"},
                new MenuItem(MenuItemsClick) { Title = "Desktop", Image = "../assets/desktop.png"},
                new MenuItem(MenuItemsClick) { Title = "Document", Image = "../assets/document.png"},
                new MenuItem(MenuItemsClick) { Title = "Download", Image = "../assets/download.png"},
                new MenuItem(MenuItemsClick) { Title = "Picture", Image = "../assets/picture.png"},
                new MenuItem(MenuItemsClick) { Title = "Music", Image = "../assets/music.png"},
                new MenuItem(MenuItemsClick) { Title = "Movie", Image = "../assets/movie.png"},
                new MenuItem(MenuItemsClick) { Title = "Trash", Image = "../assets/trash.png"}});


            SearchItems = MenuItems;
        }


        #region FullProperties

        private RightSideItemsViewModels _rightSideElements;

        public RightSideItemsViewModels RightSideElements
        {
            get { return _rightSideElements; }
            set { _rightSideElements = value;
                NotifyOfPropertyChange(() => RightSideElements);
            }
        }


        private string _hint = "Search";

        public string Hint
        {
            get { return _hint; }
            set { _hint = value; 
                NotifyOfPropertyChange(() => Hint);
            }
        }

        private string _path = "";

        public string Path
        {
            get { return _path; }
            set { _path = value;
                NotifyOfPropertyChange(() => Path);
            }
        }


        private List<MenuItem> _menuItems = new List<MenuItem>();

        public List<MenuItem> MenuItems
        {
            get { return _menuItems; }
            set
            {
                _menuItems = value;
                NotifyOfPropertyChange(() => MenuItems);
            }
        }


        private List<MenuItem> _searchItems;

        public List<MenuItem> SearchItems
        {
            get { return _searchItems; }
            set { _searchItems = value; 
                NotifyOfPropertyChange(() => SearchItems);
            }
        }


        private string _searchText;

        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                NotifyOfPropertyChange(() => SearchText);
            }
        }

        #endregion




        #region Commands
        public bool CanExecuteDrag(object parameter)
        {
            return true;
        }

        public void ExecuteDrag(object parameter)
        {
            Window w = parameter as Window;
           
            w?.DragMove();
        }


        public bool CanExecuteExit(object parameter)
        {
            return true;
        }

        public void ExecuteExit(object parameter)
        {
            Window w = parameter as Window;

            w?.Close();
        }

        public bool CanExecuteSearch(object parameter)
        {
            return true;
        }

        public void ExecuteSearch(object parameter)
        {

            if (SearchText.Length >= 1)
            {
                Hint = "";
                SearchItems = MenuItems.Where(obj => obj.Title.ToLower().Contains(SearchText.ToLower())).ToList();
            }
            else
            {
                Hint = "Search";
                SearchItems = MenuItems;
            }

        }

        public bool CanExecuteMenuItemsClick(object parameter)
        {
            return true;
        }

        public void ExecuteMenuItemsClick(object parameter)
        {
            var obj = parameter as MenuItem;

            switch (obj.Title)
            {
                case "Home":
                    _rightSideElements.InternalItems = Items.Home;
                    _rightSideElements.SearchItems = Items.Home;
                    Path = "Home";
                    break;
                case "Desktop":
                    _rightSideElements.InternalItems = Items.Desktop;
                    _rightSideElements.SearchItems = Items.Desktop;
                    Path = "Desktop";
                    break;
                case "Document":
                    _rightSideElements.InternalItems = Items.Document;
                    _rightSideElements.SearchItems = Items.Document;
                    Path = "Document";
                    break;
                case "Download":
                    _rightSideElements.InternalItems = Items.Download;
                    _rightSideElements.SearchItems = Items.Download;
                    Path = "Download";
                    break;
                case "Picture":
                    _rightSideElements.InternalItems = Items.Picture;
                    _rightSideElements.SearchItems = Items.Picture;
                    Path = "Picture";
                    break;
                case "Music":
                    _rightSideElements.InternalItems = Items.Music;
                    _rightSideElements.SearchItems = Items.Music;
                    Path = "Music";
                    break;
                case "Movie":
                    _rightSideElements.InternalItems = Items.Movie;
                    _rightSideElements.SearchItems = Items.Movie;
                    Path = "Movie";
                    break;
                case "Trash":
                    _rightSideElements.InternalItems = Items.Trash;
                    _rightSideElements.SearchItems = Items.Trash;
                    Path = "Trash";
                    break;
                default:
                    // code block
                    break;
            }
        }

        #endregion

    }
}
