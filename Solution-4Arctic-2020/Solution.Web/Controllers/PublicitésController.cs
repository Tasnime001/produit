using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Solution.Web.Models;
using Solution.Data;
using Solution.Domain.Entities;
using Solution.Service;

namespace Solution.Web.Controllers
{
    public class PublicitésController : ApiController
    {
        IServicePublicité MyService = null;
        private ServicePublicité es = new ServicePublicité();
        List<Publicité> Publicités = new List<Publicité>();
        public PublicitésController()
        {
            MyService = new ServicePublicité();
            Index();
            Publicités = Index().ToList();
        }
        public List<Publicité> Index()
        {
            List<Publicité> mandates = es.GetMany().ToList();
            List<Publicité> mandatesXml = new List<Publicité>();
            foreach (Publicité i in mandates)
            {
                mandatesXml.Add(new Publicité
                {
                    Id = i.Id,

                    Titre = i.Titre,
                   Image = i.Image,
                    Description = i.Description,
                    Prix_initial = i.Prix_initial,
                   Prix_promotion = i.Prix_promotion,

                });
            }
            return mandatesXml;
        }
        // GET api/Reclamationss
        [HttpGet]
        [Route("api/publicités")]
        public IEnumerable<Publicité> Get()
        {
            return Publicités;
        }
        // GET api/<controller>/5
        public Publicité Get(int id)
        {
            Publicité ev = MyService.GetById(id);
            return ev;
        }
        // POST: api/EventWebApi
        [Route("api/reclamations/create")]
        public IHttpActionResult PostNewFeed(Publicité postt)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            using (var ctx = new MyContext())
            {
                ctx.Publicités.Add(new Publicité()
                {
                    Id = postt.Id,

                    Titre = postt.Titre,

                    Image = postt.Image,
                    Description = postt.Description,
                   Prix_initial = postt.Prix_initial,
                   Prix_promotion = postt.Prix_promotion,

                });
                ctx.SaveChanges();
            }
            return Ok();
        }
        // PUT: api/EventWebApi/5
        [Route("api/reclamations/put")]

        public IHttpActionResult Put(int id, Publicité student)
        {

            using (var ctx = new MyContext())
            {
                var existingStudent = ctx.Publicités.Where(s => s.Id == id)
                                                        .FirstOrDefault<Publicité>();
                if (existingStudent != null)
                {
                    existingStudent.Titre = student.Titre;
                    existingStudent.Image = student.Image;
                    existingStudent.Description = student.Description;
                    existingStudent.Prix_initial = student.Prix_initial;
                    existingStudent.Prix_promotion = student.Prix_promotion;
                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            return Ok();
        }
        // DELETE: api/EventWebApi/5
        [Route("api/reclamations/delete")]

        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid student id");
            using (var ctx = new MyContext())
            {
                var student = ctx.Publicités
                    .Where(s => s.Id == id)
                    .FirstOrDefault();
                ctx.Entry(student).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }
            return Ok();
        }
    }
}