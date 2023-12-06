﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvento.API.Models;

namespace ProEvento.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        
        public IEnumerable<Evento> _evento =  new Evento[]{
                new Evento() {
                EventoId = 1,
                Local = "Salvador", 
                Tema = "Angular 11",
                Lote = "1° Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(), ImagemURL = "foto1.png"
            },
               new Evento() {
                EventoId = 2,
                Local = "Petrolina", 
                Tema = "Angular 17 e suas novidades",
                Lote = "2° Lote",
                QtdPessoas = 300,
                DataEvento = DateTime.Now.AddDays(3).ToString(), ImagemURL = "foto2.png"
            }
            };
        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
        }
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
           return _evento.Where(evento => evento.EventoId == id);
        }
          [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }
        
        
         [HttpPut("{id}")]
         public string Put(int id)
         {
            return $"Exemplo de Put com id = {id}";
         }

         [HttpDelete("{id}")]
         public string Delete(int id)
         {
            return $"Exemplo de Delete com id = {id}";
         }
    }
}

