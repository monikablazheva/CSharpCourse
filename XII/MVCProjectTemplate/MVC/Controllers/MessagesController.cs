using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Model.Classes;
using Model.Data;
using MVC.Services;

namespace MVC.Controllers
{
    public class MessagesController : Controller
    {
        private readonly MessageContext messageContext;
        private readonly IdentityContext identityContext;

        public MessagesController(MessageContext messageContext, IdentityContext identityContext)
        {
            this.messageContext = messageContext;
            this.identityContext = identityContext;
        }

        // GET: Messages
        public async Task<IActionResult> Index()
        {
            return View(await messageContext.ReadAllAsync());
        }

        // GET: Messages/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var message = await messageContext.ReadAsync(id);
            if (message == null)
            {
                return NotFound();
            }

            return View(message);
        }

        // GET: Messages/Create
        public async Task<IActionResult> Create()
        {
            ViewData["Receivers"] = new SelectList(await identityContext.ReadAllUsersAsync(), "Id", "Name");
            ViewData["Senders"] = new SelectList(await identityContext.ReadAllUsersAsync(), "Id", "Name");
            return View();
        }

        // POST: Messages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title, Text, SenderId, ReceiverId")] Message message)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await messageContext.CreateAsync(message);
                    return RedirectToAction(nameof(Index));
                }

                ViewData["Receivers"] = new SelectList(await identityContext.ReadAllUsersAsync(), "Id", "Name", message.ReceiverId);
                ViewData["Senders"] = new SelectList(await identityContext.ReadAllUsersAsync(), "Id", "Name", message.SenderId);
                return View(message);
            }
            catch (Exception ex)
            {
                HelperController.AddError("DB", ex.Message);
                return View("~/Views/Shared/Error.cshtml", HelperController.Errors);
                throw;
            }
        }

        // GET: Messages/Edit/5
        // [ModelBinder(Name = "id")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var message = await messageContext.ReadAsync(id);
            if (message == null)
            {
                return NotFound();
            }

            ViewData["Receivers"] = new SelectList(await identityContext.ReadAllUsersAsync(), "Id", "Name", message.ReceiverId);
            ViewData["Senders"] = new SelectList(await identityContext.ReadAllUsersAsync(), "Id", "Name", message.SenderId);
            return View(message);
        }

        // POST: Messages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Title,Text,SenderId,ReceiverId")] Message message)
        {
            if (id != message.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await messageContext.UpdateAsync(message);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MessageExists(message.Id))
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

            ViewData["Receivers"] = new SelectList(await identityContext.ReadAllUsersAsync(), "Id", "Id", message.ReceiverId);
            ViewData["Senders"] = new SelectList(await identityContext.ReadAllUsersAsync(), "Id", "Id", message.SenderId);
            return View(message);
        }

        // GET: Messages/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var message = await messageContext.ReadAsync(id);
            if (message == null)
            {
                return NotFound();
            }

            return View(message);
        }

        // POST: Messages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            try
            {
                await messageContext.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                HelperController.AddError("DB", ex.Message);
                return View("~/Views/Shared/Error.cshtml", HelperController.Errors);
            }
        }

        private bool MessageExists(string id)
        {
            return messageContext.Exists(id);
        }
    }
}
