using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROJECT1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
        

            return View();
        }

        public ActionResult Contact()
        {
  

            return View();
        }

        public ActionResult Missions()
        {
     

            return View();
        }


        public ActionResult MissionFAQ(int name = 0)
        {

            if (name == 1)
            {
                ViewBag.Name = "Italy Rome";
                ViewBag.President = "Michael D. Pickerd";
                ViewBag.Address = "Italy Rome Mission Piazza Carnaro, 2000141 Rome, Italy";
                ViewBag.Phone = "Phone Number: 39-06-87193443"; 
                ViewBag.Language = "Italian";
                ViewBag.Climate = " The climate in Rome is warm and temperate. In winter, there is much more rainfall in Rome than in summer. According to Köppen and Geiger, this climate is classified as Csa. The average temperature in Rome is 15.7 °C. The rainfall here averages 798 mm.";
                ViewBag.DominateReg = "Roman Catholicism";
                ViewBag.Flag = "/Content/Images/flag-of-italy.png";
            }

            if (name == 2)
            {
                ViewBag.Name = "Brazil São Paulo West Mission";
                ViewBag.President = "Thomas W. Thomas";
                ViewBag.Address = " Brazil Sao Paulo West Mission, Rua Doutor Rui Batista Pereira 165 , CEP05517-080 Sao Paulo – SP, Brazil";
                ViewBag.Phone = "Phone Number: 55-11-3725-6231";
                ViewBag.Language = "Portuguese";
                ViewBag.Climate = "São Paulo has a humid subtropical climate that is mild with no dry season, constantly moist (year-round rainfall). Summers are hot and muggy with thunderstorms. Winters are mild with precipitation from mid-latitude cyclones. Seasonality is moderate.";
                ViewBag.DominateReg = "Roman Catholicism";
                ViewBag.Flag = "/Content/Images/SanPaulo.gif";
            }

            if (name == 3)
            {
                ViewBag.Name = "Florida Tampa Mission";
                ViewBag.President = "Kendall J. Cooper";
                ViewBag.Address = "Forida Tampa Mission, 13510 N 42 St, Tampa FL 33613, USA";
                ViewBag.Phone = " Phone Number: 1-813-961-7400 ";
                ViewBag.Language = "English";
                ViewBag.Climate = "The Tampa Bay area has a humid subtropical climate (Köppen Cfa), with warm and humid summers with frequent thunderstorms and drier winters with freezing temperatures occurring every 2–3 years. The area experiences a significant summer wet season, as nearly two-thirds of the annual precipitation falls in the months of June through September.";
                ViewBag.DominateReg = "Catholic";
                ViewBag.Flag = "/Content/Images/floridaFlag.png";
            }

            return View();
        }
    }
}