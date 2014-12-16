using SudokuBasis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SudokuWeb_Week5.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }


        public ActionResult Index()
        {
            SudokuGame game = Session["game"] as SudokuGame;
            if (game == null)
            {
                NewGame();
                game = Session["game"] as SudokuGame;
            }

            return View(game);
        }

        private void NewGame()
        {
            SudokuGame game = new SudokuGame();
            game.NewGame();

            Session["game"] = game;
        }
    }
}