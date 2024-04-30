using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DatabaseFilm.Models.Services.Application;
using DatabaseFilm.Models.ViewModels;



namespace DatabaseFilm.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ICinemaService CinemaService; 
        public CinemaController(ICinemaService cinemaService)
        {
            this.CinemaService = cinemaService;
        }
        public IActionResult Index() 
        {
            List<CinemaViewModel> cinemas = CinemaService.GetCinemas();
            ViewData["Title"] = "Elenco dei film";
            return View(cinemas);
        }
        public IActionResult Detail(int id)
        {
           return View();
        }
    }
}