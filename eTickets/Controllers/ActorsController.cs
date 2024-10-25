﻿using eTickets.Data;
using eTickets.Data.Service;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.getAllAsync();
            return View(data);
        }

        //Get: Actors/Create  
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index)); 
        }
        //Get: Actors/Details/1
        public async Task<IActionResult> Details (int id)
        {
            var actorDetail = await _service.GetByIdAsync(id);
            if(actorDetail==null)
            {
                return View("Empty");
            }
            return View(actorDetail);
        }
    }
}
