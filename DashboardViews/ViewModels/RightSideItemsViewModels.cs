using Caliburn.Micro;
using DashboardViews.Commands;
using DashboardViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DashboardViews.ViewModels
{
    public class RightSideItemsViewModels : Screen
    {
        private MainViewModel _mainViewModel;
        public ICommand Search { get; set; }

        public RightSideItemsViewModels(MainViewModel mainViewModel=null)
        {
            _mainViewModel = mainViewModel;
            Search = new CommandBase(ExecuteSearch, CanExecuteSearch);
            Hint = "Search";
        }


        private string _hint;

        public string Hint
        {
            get { return _hint; }
            set { _hint = value; 
                NotifyOfPropertyChange(() => Hint);
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



        private List<MenuItem> _searchItems;

        public List<MenuItem> SearchItems
        {
            get { return _searchItems; }
            set { _searchItems = value;
                NotifyOfPropertyChange(() => SearchItems);   
            }
        }


        private List<MenuItem> _internalItems = new List<MenuItem>();

        public List<MenuItem> InternalItems
        {
            get { return _internalItems; }
            set { _internalItems = value;
                NotifyOfPropertyChange(() => InternalItems);
            }
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
                SearchItems = InternalItems.Where(obj => obj.Title.ToLower().Contains(SearchText.ToLower())).ToList();
            }
            else
            {
                Hint = "Search";
                SearchItems = InternalItems;
            }

        }


    }
}
