using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Garage2._0_Group5.Data;
using Garage2._0_Group5.Models.Entities;
using jsreport.AspNetCore;
using jsreport.Types;

namespace Garage2._0_Group5.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly Garage2_0_Group5Context _context;

        public VehiclesController(Garage2_0_Group5Context context)
        {
            _context = context;
        }

        // GET: Vehicles
        public async Task<IActionResult> Index()
        {
            return _context.Vehicle != null ?
                        View(await _context.Vehicle.ToListAsync()) :
                        Problem("Entity set 'Garage2_0_Group5Context.Vehicle'  is null.");
        }

        public async Task<IActionResult> Filter(string id, int? type, int? noOfWheels)
        {
            var model = string.IsNullOrWhiteSpace(id) ?
                    _context.Vehicle :
                    _context.Vehicle.Where(m => m.ID.StartsWith(id));

            //    var model = string.IsNullOrWhiteSpace(id) ?
            //_context.Vehicle :
            //_context.Vehicle.Where(m => m.ID.StartsWith(id));

            //model = noOfWheels is null ?
            //  _context.Vehicle :
            //  _context.Vehicle.Where(m => m.NoOfWheels.Equals(noOfWheels));

            model = type is null ?
                    model :
                    model.Where(m => (int)m.Type == type);

            return View(nameof(Index), await model.ToListAsync());
        }

        // GET: Vehicles/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.Vehicle == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.ID == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: Vehicles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Type,Color,Brand,Model,NoOfWheels,TimeOfRegistration")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehicle);
        }

        // GET: Vehicles/Edit/5
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null || _context.Vehicle == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Type,Color,Brand,Model,NoOfWheels,TimeOfRegistration")] Vehicle vehicle)
        {
            if (id != vehicle.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleExists(vehicle.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null || _context.Vehicle == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.ID == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Vehicle == null)
            {
                return Problem("Entity set 'Garage2_0_Group5Context.Vehicle'  is null.");
            }
            var vehicle = await _context.Vehicle.FindAsync(id);
            if (vehicle != null)
            {
                _context.Vehicle.Remove(vehicle);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleExists(string id)
        {
            return (_context.Vehicle?.Any(e => e.ID == id)).GetValueOrDefault();
        }

        public async Task<IActionResult> Receipt(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.ID == id);

            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        [HttpPost, ActionName("Receipt")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ReceiptConfirmed(string id)
        {
            if (_context.Vehicle == null)
            {
                return Problem("Entity set 'Garage2_0_Group5Context.Vehicle'  is null.");
            }
            var vehicle = await _context.Vehicle.FindAsync(id);
            if (vehicle != null)
            {
                _context.Vehicle.Remove(vehicle);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Receipt));
        }

        [MiddlewareFilter(typeof(JsReportPipeline))]
        public async Task<IActionResult> Print(string id)
        {
            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.ID == id);

            HttpContext.JsReportFeature().Recipe(Recipe.ChromePdf);
            return View(vehicle);
            
        }

        private bool VehicleModelExists(string id)
        {
            return _context.Vehicle.Any(e => e.ID == id);
        }

        //Action method that returns a custom error message about Uniqueness of Licence Number
        [AcceptVerbs("GET", "POST")]
        public IActionResult UniqueLicenceNumber(string Id)
        {
            if (_context.Vehicle.Any(v => v.ID == Id))
            {
                return Json($"This registration number {Id} is already in use.");
            }

            return Json(true);
        }
    }
}
