using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechizzianXamarin2
{
    public class Techizzian
    {
        #region Public Properties

        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get { return string.Format("{0}, {1}", LastName, FirstName); } }
        public string ImageUri { get; set; }
        public int OrderSeq { get; set; }
        public int DroidImageUri { get; set; }

        #endregion
    }
}
