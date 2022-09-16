using Caliburn.Micro;
using DashboardViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardViews.ViewModels
{
    public class RightSideItemsViewModels : Screen
    {
        private MainViewModel _mainViewModel;
        public RightSideItemsViewModels(MainViewModel mainViewModel=null)
        {
            _mainViewModel = mainViewModel;
            
        }


        private List<MenuItem> _internalItems = new List<MenuItem>();

        public List<MenuItem> InternalItems
        {
            get { return _internalItems; }
            set { _internalItems = value; 
                NotifyOfPropertyChange(() => InternalItems);
            }
        }

    }
}
