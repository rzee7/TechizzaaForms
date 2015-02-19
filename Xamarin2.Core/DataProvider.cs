using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechizzianXamarin2
{
   public class DataProvider
   {
       #region Get Techizzians

       public static List<Techizzian> GetTechizzians()
       {
           var techizzianList = new List<Techizzian>
                                      {
                                          new Techizzian { FirstName = "Rupreet", LastName = "Gujral", ImageUri = "RupreetGujral.png", OrderSeq=1, Title="Co Founder" },
                                          new Techizzian { FirstName = "Ketan", LastName = "Sharma", ImageUri = "KetanSharma.png", OrderSeq=2, Title="Co Founder"  },
                                          new Techizzian { FirstName = "Shagun", LastName = "Bawa", ImageUri = "ShagunBawa.png", OrderSeq=3 , Title="Genaral Manager" },
                                          new Techizzian { FirstName = "Mohd", LastName = "Riyaz", ImageUri = "MohdRiyaz.png" , OrderSeq=4, Title="Dev Team Leader" },
                                          new Techizzian { FirstName = "Manish", LastName = "Singh", ImageUri = "ManishSingh.png" , OrderSeq=5, Title="Sr. Software Developer" },
                                          new Techizzian { FirstName = "Nazar", LastName = "Naqvi", ImageUri = "NazarNaqvi.png", OrderSeq=7 , Title="Sr. Software Developer" },
                                          new Techizzian { FirstName = "Anil", LastName = "Sethi", ImageUri = "AnilSethi.png" , OrderSeq=6 , Title="Dev Team Leader" },
                                          new Techizzian { FirstName = "Harpreet", LastName = "Kaur", ImageUri = "HarpreetKaur.png" , OrderSeq=8, Title="Sr. Software Developer" },
                                          new Techizzian { FirstName = "Pardeep", LastName = "Tandon", ImageUri = "PardeepTandon.png", OrderSeq=9, Title="Sr. Software Developer"  },
                                          new Techizzian { FirstName = "Gagan", LastName = "Sethi", ImageUri = "GagandeepSingh.png", OrderSeq=10 , Title="Sr. Software Developer" },
                                          new Techizzian { FirstName = "Naina", LastName = "Sharma", ImageUri = "NainaSharma.png", OrderSeq=11 , Title="Software Developer" },
                                          new Techizzian { FirstName = "Neha", LastName = "Gupta", ImageUri = "NehaGupta.png", OrderSeq=12 , Title="Software Developer"  },
                                          new Techizzian { FirstName = "Aman", LastName = "Walia", ImageUri = "AmanWalia.png", OrderSeq=13, Title="Marketting Executive"  },
                                          new Techizzian { FirstName = "Meenal", LastName = "Sharma", ImageUri = "MeenalSharma.png" , OrderSeq=14, Title="Project Manager" }, //change last name
                                          new Techizzian { FirstName = "Bhavna", LastName = "Pruthi", ImageUri = "BhavnaPruthi.png", OrderSeq=15, Title="Software Developer"  },
                                          new Techizzian { FirstName = "Neha", LastName = "Shrivastava", ImageUri = "NehaShrivastava.png", OrderSeq=16, Title="HR Executive"  } // change last name
                                      };

           return techizzianList;
       }

       #endregion
   }
}
