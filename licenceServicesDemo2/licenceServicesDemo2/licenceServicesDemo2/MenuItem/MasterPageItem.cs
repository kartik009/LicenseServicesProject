using System;
using System.Collections.Generic;
using System.Text;

namespace licenceServicesDemo2.MenuItem
{
    public enum MenuItemType
    {
        Server,
        Feature
    }

    public class MasterPageItem
    {
        public MenuItemType ID { get; set; }

        public string Title
        {
            get;
            set;
        }
        public string Icon
        {
            get;
            set;
        }

    }
}
