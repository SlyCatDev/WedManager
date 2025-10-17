using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WedManager.Api.Data;
using WedManager.Api.Models;

namespace WedManager.Api.Controllers;
[ApiController]
[Route("api/[controller]")]

public class PrestatairesController(ApplicationDbContext db) : Controller
    {
        private readonly ApplicationDbContext _db = db;

    [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _db.Prestataires.ToListAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var p = await _db.Prestataires.FindAsync(id);
            return p == null ? NotFound() : Ok(p);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Prestataire prest)
        {
            _db.Prestataires.Add(prest);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = prest.Id }, prest);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Prestataire prest)
        {
            if (id != prest.Id) return BadRequest();
            _db.Entry(prest).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var p = await _db.Prestataires.FindAsync(id);
            if (p == null) return NotFound();
            _db.Prestataires.Remove(p);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
