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
using Garage2._0_Group5.Models.ViewModels;

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

            var model = _context.Vehicle.AsNoTracking()
                .Select(v => new VehicleCreateViewModel
                {
                    LicenseNumber = v.LicenseNumber,
                    VehicleColor = v.VehicleColor,
                    TypeOfVehicle = v.VehicleType.TypeOfVehicle,

                    TimeOfRegistration = v.TimeOfRegistration,
                });

            return View(await model.ToListAsync());
        }


        //public async Task<IActionResult> Filter(string id, int? type, int? noOfWheels)
        //{
        //    var model = string.IsNullOrWhiteSpace(id) ?
        //            _context.Vehicle :
        //            _context.Vehicle.Where(m => m.LicenseNumber.StartsWith(id));

        //public async Task<IActionResult> Filter(int id, int? type, int? noOfWheels)
        //{
        //    var model = int.IsNullOrWhiteSpace(id) ?
        //            _context.Vehicle :
        //            _context.Vehicle.Where(m => m.Id.StartsWith(id));

        //    //    var model = string.IsNullOrWhiteSpace(id) ?
        //    //_context.Vehicle :
        //    //_context.Vehicle.Where(m => m.ID.StartsWith(id));

        //    //model = noOfWheels is null ?
        //    //  _context.Vehicle :
        //    //  _context.Vehicle.Where(m => m.NoOfWheels.Equals(noOfWheels));

        //    model = type is null ?
        //            model :
        //            model.Where(m => (int)m.Type == type);

        //    return View(nameof(Index), await model.ToListAsync());
        //}

        // GET: Vehicles/Details/5
        //public async Task<IActionResult> Details()
        //{

        //    //var model = _context.Vehicle.AsNoTracking()
        //    //    .Select(v => new VehicleDetailsViewModel
        //    //        {
        //    //            LicenseNumber = v.LicenseNumber,
        //    //            VehicleColor = v.VehicleColor,
        //    //            Brand = v.Brand,
        //    //            Model = v.Model,
        //    //            TypeOfVehicle = v.VehicleType.TypeOfVehicle,
        //    //            Wheels = v.VehicleType.Wheels,
        //    //            TimeOfRegistration = v.TimeOfRegistration,
        //    //    });

        //    //return View(await model.ToListAsync());


        //    if (id == null || _context.Vehicle == null)
        //    {
        //        return NotFound();
        //    }

        //    var vehicle = await _context.Vehicle
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (vehicle == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(vehicle);
        //}

        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.Vehicle == null)
        //    {
        //        return NotFound();
        //    }

        //    var vehicle = await _context.Vehicle
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (vehicle == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(vehicle);
        //}

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
        public async Task<IActionResult> Create(VehicleCreateViewModel viewModel)
        {


            if (ModelState.IsValid)
            {
                var vehicle = new Vehicle
                {
                    LicenseNumber = viewModel.LicenseNumber,
                    VehicleColor = viewModel.VehicleColor,
                    Brand = viewModel.Brand,
                    Model = viewModel.Model,
                    TimeOfRegistration = viewModel.TimeOfRegistration,
                    VehicleType = new VehicleType
                    {
                        TypeOfVehicle = viewModel.TypeOfVehicle,
                        Wheels = viewModel.Wheels,
                    }

                };


                _context.Add(vehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
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
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,Color,Brand,Model,NoOfWheels,TimeOfRegistration")] Vehicle vehicle)
        {
            if (id != vehicle.Id)
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
                    if (!VehicleExists(vehicle.Id))
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
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Vehicle == null)
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
            return (_context.Vehicle?.Any(e => e.Id == id)).GetValueOrDefault();
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

        //Action method that returns a custom error message about Uniqueness of Licence Number
        [AcceptVerbs("GET", "POST")]

        public IActionResult UniqueLicenseNumber(string registrationNum)
        {
            if (_context.Vehicle.Any(v => v.LicenseNumber == registrationNum))

            {
                return Json($"This registration number {registrationNum} is already in use.");

            }
            return Json(true);
        }
    }
}
