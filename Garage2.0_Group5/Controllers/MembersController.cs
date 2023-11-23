using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Garage2._0_Group5.Data;
using Garage2._0_Group5.Models.Entities;
using Garage2._0_Group5.Models.ViewModels;
using Bogus;
using Bogus.Extensions.Sweden;
using AutoMapper;

namespace Garage2._0_Group5.Controllers
{
    public class MembersController : Controller
    {
        private readonly Garage2_0_Group5Context _context;
        private readonly IMapper mapper;
        private readonly Faker faker;

        public MembersController(Garage2_0_Group5Context context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
            faker = new Faker();
        }

        // GET: Members
        public async Task<IActionResult> Index()
        {
            //var t = _context.Member.ToList();
            //var t2 = _context.Member.Include(m=>m.Vehicles).ToList();
            //var t3 = _context.Member.Include(m=>m.Vehicles).ThenInclude(v=>v.VehicleType).ToList();
            //var c = _context.Member.Include(m => m.VehicleTypes);

            //var model = _context.Member.OrderByDescending(m => m.Id)
            //    .Select(m => new MemberIndexViewModel
            //    {
            //        Id = m.Id,
            //        NameFullName = m.Name.FullName,
            //        Email = m.Email,
            //        PersonNumber = m.PersonNumber,
            //        //VehicleInfos = m.Vehicles.Select(v => new VehicleInfo
            //        //{
            //        //    LicenseNumber = v.LicenseNumber,
            //        //    TimeOfRegistration = v.TimeOfRegistration
            //        //})
            //    }).Take(5);

            var model = mapper.ProjectTo<MemberIndexViewModel>(_context.Member)
                .OrderByDescending(x => x.Id)
                .Take(5);

            return View(await model.ToListAsync());
        }

        // GET: Members/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Member == null)
            {
                return NotFound();
            }

            var member = await _context.Member
                .FirstOrDefaultAsync(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // GET: Members/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Members/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MemberCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                //var member = new Member(new Name(viewModel.NameFirstName, viewModel.NameLastName), viewModel.Email, faker.Person.Personnummer()) { };

                var member = mapper.Map<Member>(viewModel);
                member.PersonNumber = faker.Person.Personnummer();

                _context.Add(member);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        // GET: Members/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Member == null)
            {
                return NotFound();
            }

            var member = await _context.Member.FindAsync(id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: Members/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Email,PersonNumber")] Member member)
        {
            if (id != member.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(member);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberExists(member.Id))
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
            return View(member);
        }

        // GET: Members/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Member == null)
            {
                return NotFound();
            }

            var member = await _context.Member
                .FirstOrDefaultAsync(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Member == null)
            {
                return Problem("Entity set 'Garage2_0_Group5Context.Member'  is null.");
            }
            var member = await _context.Member.FindAsync(id);
            if (member != null)
            {
                _context.Member.Remove(member);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MemberExists(int id)
        {
            return (_context.Member?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        //Action method that returns a custom error message about Uniqueness of Person Number
        [AcceptVerbs("GET", "POST")]
        public IActionResult UniquePersonNumber(string personNumber)
        {
            if (_context.Member.Any(p => p.PersonNumber == personNumber))
            {
                return Json($"This person number {personNumber} is already in use.");
            }

            return Json(true);
        }
    }
}
