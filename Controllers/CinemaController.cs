using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DatabaseFilm.Models.Services.Application;
using DatabaseFilm.Models.ViewModels;
using DatabaseFilm.Models;



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
            CinemaDetailViewModel viewModel = CinemaService.GetCinema(id);
            ViewData["Title"] = viewModel.Titolo;
            return View(viewModel);
        }
        public IActionResult Aggiungi()
        {
            return View();
        }

        public IActionResult AggiungiFilm(string Titolo, string Anno, string Genere)
        {
            CinemaService.AddCinema(Titolo, Anno, Genere);
            // La view non funziona perché il cinema non é di tipo CinemaViewModel fixo piú in la -Giovanni
            return View("../Cinema/Index");
        }
    }
}