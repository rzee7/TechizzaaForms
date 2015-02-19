using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TechizzaXamarin3;
using Xamarin.Forms;

namespace TechizzaaXamarin3.Second
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new ClassHierarchyPage();
        }
    }
}
