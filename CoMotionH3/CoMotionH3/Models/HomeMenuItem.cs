using System;
using System.Collections.Generic;
using System.Text;

namespace CoMotionH3.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        SignIn,
        Hasher,
        Trail
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
