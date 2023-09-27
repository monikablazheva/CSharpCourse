using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Model.Classes;
using Model.Data;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class HobbiesController : Controller
    {
        private readonly HobbyContext hobbyContext;
        private readonly IdentityContext identityContext;

        public HobbiesController(HobbyContext hobbyContext, IdentityContext identityContext)
        {
            this.hobbyContext = hobbyContext;
            this.identityContext = identityContext;
        }

        // GET: Hobbies
        public async Task<IActionResult> Index()
        {
            return View(await hobbyContext.ReadAllAsync());
        }

        // GET: Hobbies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hobby = await hobbyContext.ReadAsync((int)id);
            if (hobby == null)
            {
                return NotFound();
            }

            return View(hobby);
        }

        // GET: Hobbies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hobbies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name")] Hobby hobby)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await hobbyContext.CreateAsync(hobby);
                    return RedirectToAction(nameof(Index));
                }
                return View(hobby);
            }
            catch (Exception ex)
            {
                HelperController.AddError("DB", ex.Message);
                return View("~/Views/Shared/Error.cshtml", HelperController.Errors);
            }
        }

        // GET: Hobbies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hobby = await hobbyContext.ReadAsync((int)id);
            if (hobby == null)
            {
                return NotFound();
            }
            return View(hobby);
        }

        // POST: Hobbies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Hobby hobby)
        {
            if (id != hobby.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await hobbyContext.UpdateAsync(hobby);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HobbyExists(hobby.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        HelperController.AddError("Concurrency", "Another user is updating the same hobby!");
                        return View("~/Views/Shared/Error.cshtml", HelperController.Errors);
                    }
                }
            }
            return View(hobby);
        }

        // GET: Hobbies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hobby = await hobbyContext.ReadAsync((int)id);
            if (hobby == null)
            {
                return NotFound();
            }

            return View(hobby);
        }

        // POST: Hobbies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await hobbyContext.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                HelperController.AddError("DB", ex.Message);
                return View("~/Views/Shared/Error.cshtml", HelperController.Errors);
            }
        }

        // GET: Hobbies/HobbyToUser/string
        public async Task<IActionResult> HobbyToUser(string id)
        {
            ViewBag.Hobbies = new SelectList(await hobbyContext.ReadAllAsync(), "Id", "Name");

            if (id == null)
            {    
                ViewBag.Users = new SelectList(await identityContext.ReadAllUsersAsync(), "Id", "Name");
            }
            else
            {
                User loggedUser = await identityContext.ReadUserAsync(id);
                ViewBag.Users = new SelectList(
                    new List<User>()
                    {
                        loggedUser
                    }, 
                    "Id", "Name");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> HobbyToUser([Bind("HobbyId, UserId")]HobbyToUserViewModel huvm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Hobby hobby = await hobbyContext.ReadAsync(huvm.HobbyId);
                    User user = await identityContext.ReadUserAsync(huvm.UserId);
                    hobby.Users.Add(user);
                    await hobbyContext.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HobbyExists(huvm.HobbyId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        HelperController.AddError("Concurrency", "Another user is updating the same hobby!");
                        return View("~/Views/Shared/Error.cshtml", HelperController.Errors);
                    }
                }
            }
            
            return View(huvm);
        }

        private bool HobbyExists(int id)
        {
            return hobbyContext.Exists(id);
        }
    }
}
