using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarCapstone.Models;

namespace CarCapstone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly DealershipDBContext _context;

        public CarController(DealershipDBContext context)
        {
            _context = context;
        }

        // GET: api/Car
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> GetCars()
        {
            return await _context.Cars.ToListAsync();
        }

        // GET: api/Car/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);

            if (car == null)
            {
                return NotFound();
            }

            return car;
        }

        // PUT: api/Car/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCar(int id, Car car)
        {
            if (id != car.Id)
            {
                return BadRequest();
            }

            _context.Entry(car).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Car
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Car>> PostCar(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCar", new { id = car.Id }, car);
        }

        // DELETE: api/Car/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }

            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpGet("model/{model}")]
        public async Task<ActionResult<IEnumerable<Car>>> GetModel(string model)
        {

            int matches = _context.Cars.Count(x => x.Model.Contains(model));

            if (matches > 0)
            {
                return await _context.Cars.Where(x => x.Model.Contains(model)).ToListAsync();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("make/{make}")]
        public async Task<ActionResult<IEnumerable<Car>>> GetMake(string make)
        {

            int matches = _context.Cars.Count(x => x.Make.Contains(make));

            if (matches > 0)
            {
                return await _context.Cars.Where(x => x.Make.Contains(make)).ToListAsync();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("color/{color}")]
        public async Task<ActionResult<IEnumerable<Car>>> GetColor(string color)
        {

            int matches = _context.Cars.Count(x => x.Color.Contains(color));

            if (matches > 0)
            {
                return await _context.Cars.Where(x => x.Color.Contains(color)).ToListAsync();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("year/{year}")]
        public async Task<ActionResult<IEnumerable<Car>>> GetYear(string year)
        {

            int matches = _context.Cars.Count(x => x.Year.ToString().Contains(year));

            if (matches > 0)
            {
                return await _context.Cars.Where(x => x.Year.ToString().Contains(year)).ToListAsync();
            }
            else
            {
                return NotFound();
            }
        }

        private bool CarExists(int id)
        {
            return _context.Cars.Any(e => e.Id == id);
        }
    }
}
