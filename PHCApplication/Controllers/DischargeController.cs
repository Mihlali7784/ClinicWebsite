using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;
using System.Security.Claims;

namespace PHCApplication.Controllers
{
    
      public class DischargeController : Controller
      {
            private readonly PHCApplicationDbContext _context;

            public DischargeController(PHCApplicationDbContext context)
            {
                _context = context;
            }

            // GET: Discharge
            public async Task<IActionResult> Index()
            {
            //var pHCApplicationDbContext = _context.Discharge.Include(b => b.ApplicationUser);
            //return View(await pHCApplicationDbContext.ToListAsync());

            var applyDischarges = await _context.Discharge
                                      .Include(d => d.ApplicationUser)
                                      .ToListAsync();
            return View(applyDischarges);
        }

            // GET: Discharge/Details/5
            public async Task<IActionResult> Details(int? id)
            {


            //if (id == null || _context.Discharge == null)
            //{
            //    return NotFound();
            //}

            //var discharge = await _context.Discharge
            //.Include(b => b.ApplicationUser)
            //.FirstOrDefaultAsync(m => m.DischargeId == id);
            //if (discharge == null)
            //{
            //    return NotFound();
            //}

            //return View(discharge);

                if (id == null)
                {
                  return NotFound();
                }

                var discharge = await _context.Discharge
                                               .Include(d => d.ApplicationUser)
                                               .FirstOrDefaultAsync(m => m.DischargeId == id);
                if (discharge == null)
                {
                   return NotFound();
                }

                return View(discharge);

            }

            // GET: Discharge/Create
            public IActionResult Create()
            {
                 ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id");
                 return View();
            }

            // POST: Discharge/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("DischargeId,CheckIn,DischargeDate,Room,Status,Summary,UserID")] Discharge discharge)
            {

            //// Retrieve the user's ID from the claims
               var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);


               discharge.UserID = userId;

            //   // Set the UserID property of the Discharge entity
            //   discharge.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            //   _context.Add(discharge);
            //   await _context.SaveChangesAsync();
            //   TempData["SuccessMessage"] = "Discharge created Successfully!";
            //   return RedirectToAction(nameof(Index));

                if (ModelState.IsValid)
                {
                   discharge.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
                   _context.Add(discharge);
                   await _context.SaveChangesAsync();
                  TempData["SuccessMessage"] = "Discharge created Successfully!";
                  return RedirectToAction(nameof(Index));
                }
                return View(discharge);

                ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", discharge.UserID);

                return View(discharge);
            }

            // GET: Bookings/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null || _context.Discharge == null)
                {
                    return NotFound();
                }

                var discharge = await _context.Discharge.FindAsync(id);
                if (discharge == null)
                {
                    return NotFound();
                }
                ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", discharge.UserID);
                return View(discharge);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("DischargeId,CheckIn,DischargeDate,Room,Status,Summary,UserID")] Discharge discharge)
            {
               if (id != discharge.DischargeId)
               {
                  return NotFound();
               }



                _context.Update(discharge);
                await _context.SaveChangesAsync();


               if (!DischargeExists(discharge.DischargeId))
               {
                  return NotFound();
               }

               return RedirectToAction(nameof(Index));

               //ViewData["UserID"] = new SelectList(_context.Users, "Id", "FirstName", booking.UserID);


               var users = _context.Users.Select(user => new
               {
                 Id = user.Id,
                 FullName = user.FirstName + " " + user.LastName // Concatenate first name and last name
               }).ToList();

               ViewData["UserID"] = new SelectList(users, "Id", "FullName");

               return View(discharge);
            }



            // GET: Discharge/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
               if (id == null || _context.Discharge == null)
               {
                return NotFound();
               }

                var bookings = await _context.Discharge
                .Include(b => b.ApplicationUser)
                .FirstOrDefaultAsync(m => m.DischargeId == id);
               if (bookings == null)
               {
                 return NotFound();
               }

               return View(bookings);
            }

            // POST: Discharge/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
               if (_context.Bookings == null)
               {
                  return Problem("Entity set 'PHCApplicationDbContext.Booking'  is null.");
               }
               var booking = await _context.Bookings.FindAsync(id);
               if (booking != null)
               {
                 _context.Bookings.Remove(booking);
               }

               await _context.SaveChangesAsync();
               return RedirectToAction(nameof(Index));
            }
            private bool DischargeExists(int id)
            {
               return (_context.Bookings?.Any(e => e.BookingsId == id)).GetValueOrDefault();
            }

    }
}

