﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;
namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;
        
        public EventosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _context.Eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetbyId(int id)
        {
           return _context.Eventos.Where(evento => evento.EnventoId == id);
        }
    }
}
