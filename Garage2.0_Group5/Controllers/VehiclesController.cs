﻿using System;
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

		public async Task<IActionResult> Filter(string licenseNumber, int? type, int? noOfWheels)
		{


            var model = string.IsNullOrWhiteSpace(licenseNumber) ?
                    _context.Vehicle :
                    _context.Vehicle.Where(m => m.LicenseNumber.StartsWith(licenseNumber));

            //var model = licenseNumber == null ?
            //       _context.Vehicle :
            //       _context.Vehicle.Where(m => m.LicenseNumber.StartsWith(licenseNumber));



            model = noOfWheels == null ?
		            _context.Vehicle :
		            _context.Vehicle.Where(m => m.NoOfWheels.Equals(noOfWheels));

			
            model = type is null ?
                    model :
                    model.Where(m => (int)m.Type == type);

            return View(nameof(Index),await model.ToListAsync());
		}

		// GET: Vehicles/Details/5
		public async Task<IActionResult> Details(int? id)
        {
            if (licenseNumber == null || _context.Vehicle == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.LicenseNumber == licenseNumber);
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
        public async Task<IActionResult> Create([Bind("Type,LicenseNumber,Color,Brand,Model,NoOfWheels,TimeOfRegistration")] Vehicle vehicle)
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
        public async Task<IActionResult> Edit(string? licenseNumber)
        {
            if (licenseNumber == null || _context.Vehicle == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle.FindAsync(licenseNumber);
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
        public async Task<IActionResult> Edit(string licenseNumber, [Bind("Type,LicenseNumber,Color,Brand,Model,NoOfWheels,TimeOfRegistration")] Vehicle vehicle)
        {
            if (licenseNumber != vehicle.LicenseNumber)
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
                    if (!VehicleExists(vehicle.LicenseNumber))
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
        





        public ActionResult CheckExistingLicenseNumber(string LicenseNumber)
        {
            bool ifLicenseNumberExist = false;
            try
            {
                ifLicenseNumberExist = LicenseNumber.Equals(vehicle.LicenseNumber) ? true : false;
                return Json(!ifLicenseNumberExist, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }








        // GET: Vehicles/Delete/5
        public async Task<IActionResult> Delete(string? licenseNumber)
        {
            if (licenseNumber == null || _context.Vehicle == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.LicenseNumber == licenseNumber);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string LicenseNumber)
        {
            if (_context.Vehicle == null)
            {
                return Problem("Entity set 'Garage2_0_Group5Context.Vehicle'  is null.");
            }
            var vehicle = await _context.Vehicle.FindAsync(LicenseNumber);
            if (vehicle != null)
            {
                _context.Vehicle.Remove(vehicle);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleExists(string licenseNumber)
        {
          return (_context.Vehicle?.Any(e => e.LicenseNumber == licenseNumber)).GetValueOrDefault();
        }

        public async Task<IActionResult> Receipt(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.Id == id);

            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        [HttpPost, ActionName("Receipt")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ReceiptConfirmed(int id)
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
        public async Task<IActionResult> Print(int id)
        {
            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.Id == id);


            HttpContext.JsReportFeature().Recipe(Recipe.ChromePdf);
            return View(vehicle);
        }

        private bool VehicleModelExists(int id)
        {
            return _context.Vehicle.Any(e => e.Id == id);
        }
    }
}
