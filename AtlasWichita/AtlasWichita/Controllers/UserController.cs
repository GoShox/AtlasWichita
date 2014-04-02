using AtlasWichita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtlasWichita.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /User/Quiz
        public ActionResult Quiz(string button1, string button2)
        {
            Quiz userQuiz = new Quiz();
            List<Adjective> adjectiveList = new List<Adjective>();
            makeList(adjectiveList);
            return View();
        }

        private void makeList(List<Adjective> adjectiveList)
        {
            Adjective religious = new Adjective("Religious", 4, 8, 2, 2, -4, -4, -6, 0, -4, -6, -2);
            adjectiveList.Add(religious);
            Adjective local = new Adjective("Local", -4, -2, 2, 4, -2, 4, 4, 10, 2, -2, -2);
            adjectiveList.Add(local);
            Adjective vintage = new Adjective("Vintage", -2, -2, 2, 4, -2, 4, 2, 4, -2, -4, -4);
            adjectiveList.Add(vintage);
            Adjective independent = new Adjective("Independent", -6, -6, 2, 2, 2, 4, 10, -2, 4, 0, 2);
            adjectiveList.Add(independent);
            Adjective adventurous = new Adjective("Adventurous", -6, -4, 0, 2, 2, 6, 8, -4, 8, 2, 2);
            adjectiveList.Add(adventurous);
            Adjective exotic = new Adjective("Exotic", -4, -6, -2, -2, 4, 2, 4, -6, 8, 4, 4);
            adjectiveList.Add(exotic);
            Adjective materialistic = new Adjective("Materialistic", 2, 4, -6, -6, 6, -6, -6, -2, -2, 2, 8);
            adjectiveList.Add(materialistic);
            Adjective extroverted = new Adjective("Extroverted", 0, 2, -2, -2, 6, -2, 0, -4, 4, 4, 4);
            adjectiveList.Add(extroverted);
            Adjective aggressive = new Adjective("Aggressive", -2, -2, 2, 2, 0, 4, 2, 0, 2, 2, -2);
            adjectiveList.Add(aggressive);
            Adjective organized = new Adjective("Organized", 6, 6, 0, -2, -4, -2, -4, 2, -2, -2, -2);
            adjectiveList.Add(organized);
            Adjective techsavvy = new Adjective("Tech-savvy", -4, -2, -4, -4, 4, -2, 2, -2, 2, 6, 2);
            adjectiveList.Add(techsavvy);
            Adjective loyal = new Adjective("Loyal", 4, 2, 0, 0, -6, 2, -2, 4, 0, 0, 0);
            adjectiveList.Add(loyal);
            Adjective risktaker = new Adjective("Risk-taker", -4, -6, 0, 2, 2, 4, 4, -2, 4, 2, 2);
            adjectiveList.Add(risktaker);
            Adjective connected = new Adjective("Connected", 2, 2, -4, -2, 2, -2, 0, 2, 2, 0, 0);
            adjectiveList.Add(connected);
            Adjective urban = new Adjective("Urban", -2, -2, -4, -6, 4, 2, 2, 0, 4, 4, 2);
            adjectiveList.Add(urban);
            Adjective modern = new Adjective("Modern", -2, -2, -4, -6, 4, -4, 2, 0, 4, 10, 4);
            adjectiveList.Add(modern);
            Adjective hipster = new Adjective("Hipster", -6, -4, -6, -4, 6, 0, -2, 4, -2, 2, -6);
            adjectiveList.Add(hipster);
            Adjective gritty = new Adjective("Gritty", -6, -6, 6, 6, -8, 10, 4, 6, -2, -2, -8);
            adjectiveList.Add(gritty);
            Adjective upscale = new Adjective("Upscale", 6, 4, -6, -6, 4, -8, -4, -2, -4, -4, 8);
            adjectiveList.Add(upscale);
            Adjective active = new Adjective("Active", 0, 0, 2, 0, -2, 2, 0, -2, 4, -2, -2);
            adjectiveList.Add(active);
            Adjective reserved = new Adjective("Reserved", 2, 6, 2, 2, -4, -2, -2, 2, -6, -4, -4);
            adjectiveList.Add(reserved);
            Adjective outgoing = new Adjective("Outgoing", -2, 2, 0, -2, 0, 0, 2, -2, 2, 2, 2);
            adjectiveList.Add(outgoing);
            Adjective creative = new Adjective("Creative", -4, -4, -4, -4, 2, 2, 4, -2, 2, 4, 0);
            adjectiveList.Add(creative);
            Adjective edgy = new Adjective("Edgy", -4, -4, 0, 0, -2, 4, 6, 2, 4, 2, -2);
            adjectiveList.Add(edgy);
            Adjective hip = new Adjective("Hip", -2, -4, -4, -4, 2, 0, -2, 2, 4, 4, -2);
            adjectiveList.Add(hip);
            Adjective traditional = new Adjective("Traditional", 8, 6, 4, 6, -10, -4, -4, 2, -6, -6, 2);
            adjectiveList.Add(traditional);
            Adjective classy = new Adjective("Classy", 8, 8, -4, -4, -2, -6, -2, 2, -6, -4, 6);
            adjectiveList.Add(classy);
            Adjective whitecollar = new Adjective("White-collar", 4, 6, -10, -2, -2, -4, -2, -2, -4, 0, 2);
            adjectiveList.Add(whitecollar);
            Adjective bluecollar = new Adjective("Blue-collar", -4, -2, 10, 6, -2, 4, 2, 2, -2, -2, -6);
            adjectiveList.Add(bluecollar);
            Adjective rural = new Adjective("Rural", -2, -2, 6, 6, -6, 4, 4, 4, -6, -4, -4);
            adjectiveList.Add(rural);
        }
    }
}