﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Garage2._0_Group5.Data;
using Garage2._0_Group5.Models.Entities;

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
            var garage2_0_Group5Context = _context.Vehicle.Include(v => v.Member).Include(v => v.VehicleType);
            return View(await garage2_0_Group5Context.ToListAsync());
        }

        // GET: Vehicles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Vehicle == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .Include(v => v.Member)
                .Include(v => v.VehicleType)
                .FirstOrDefaultAsync(m => m.MemberId == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: Vehicles/Create
        public IActionResult Create()
        {
            ViewData["MemberId"] = new SelectList(_context.Member, "Id", "Email");
            ViewData["VehicleTypeId"] = new SelectList(_context.VehicleType, "Id", "TypeOfVehicle");
            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LicenseNumber,Color,Brand,Model,TimeOfRegistration,MemberId,VehicleTypeId")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MemberId"] = new SelectList(_context.Member, "Id", "Email", vehicle.MemberId);
            ViewData["VehicleTypeId"] = new SelectList(_context.VehicleType, "Id", "TypeOfVehicle", vehicle.VehicleTypeId);
            return View(vehicle);
        }

        // GET: Vehicles/Edit/5
        public async Task<IActionResult> Edit(int? id)
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
            ViewData["MemberId"] = new SelectList(_context.Member, "Id", "Email", vehicle.MemberId);
            ViewData["VehicleTypeId"] = new SelectList(_context.VehicleType, "Id", "TypeOfVehicle", vehicle.VehicleTypeId);
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LicenseNumber,Color,Brand,Model,TimeOfRegistration,MemberId,VehicleTypeId")] Vehicle vehicle)
        {
            if (id != vehicle.MemberId)
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
                    if (!VehicleExists(vehicle.MemberId))
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
            ViewData["MemberId"] = new SelectList(_context.Member, "Id", "Email", vehicle.MemberId);
            ViewData["VehicleTypeId"] = new SelectList(_context.VehicleType, "Id", "TypeOfVehicle", vehicle.VehicleTypeId);
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Vehicle == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .Include(v => v.Member)
                .Include(v => v.VehicleType)
                .FirstOrDefaultAsync(m => m.MemberId == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
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

        private bool VehicleExists(int id)
        {
          return (_context.Vehicle?.Any(e => e.MemberId == id)).GetValueOrDefault();
        }
    }
}
