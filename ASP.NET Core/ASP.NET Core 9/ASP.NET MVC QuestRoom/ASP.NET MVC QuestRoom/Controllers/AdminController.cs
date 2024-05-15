using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.NET_MVC_QuestRoom.Data.Entity;
using ASP.NET_MVC_QuestRoom.Models.AdminViewModels;
using System.Drawing;
using Microsoft.DotNet.Scaffolding.Shared;
using Humanizer;
using ASP.NET_MVC_QuestRoom.Models;

namespace ASP.NET_MVC_QuestRoom.Controllers
{
	public class AdminController : Controller
	{
		private readonly QuestRoomContext _context;
		private readonly IWebHostEnvironment _hostingEnvironment;
		private readonly Microsoft.Extensions.Logging.ILogger _logger;

		public AdminController(QuestRoomContext context, IWebHostEnvironment hostingEnvironment, ILoggerFactory logger)
		{
			_context = context;
			_hostingEnvironment = hostingEnvironment;
			_logger = logger.CreateLogger<QuestRoomContext>();
		}

		// GET: Admin/index
		public async Task<IActionResult> Index(string? search, int page = 1)
		{
			IQueryable<QuestRoom> rooms = _context.QuestRooms;
			IndexViewModel vM = new IndexViewModel() { Rooms = rooms };
			if (search is not null)
			{
				List<QuestRoom> emptyRoomsList = new List<QuestRoom>();
				foreach (var item in rooms)
				{
					if (item.Description.ToLower().Contains(search.ToLower()))
					{
						emptyRoomsList.Add(item);
					}
					else if (item.Address.ToLower().Contains(search.ToLower()))
					{
						emptyRoomsList.Add(item);
					}
					else if (item.Company.ToLower().Contains(search.ToLower()))
					{
						emptyRoomsList.Add(item);
					}
					else if (item.Difficulty.ToString() == search)
					{
						emptyRoomsList.Add(item);
					}
					else if (item.QuestName.ToLower().Contains(search.ToLower()))
					{
						emptyRoomsList.Add(item);
					}

				}
				vM.Rooms = emptyRoomsList;
			}
			
			int pageSize = 8;
			int count = vM.Rooms.Count();
			vM.Rooms = vM.Rooms.Skip((page - 1) * pageSize).Take(pageSize).ToList();

			PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
			vM.PageViewModel = pageViewModel;

			return _context.QuestRooms != null ?
						View(vM) :
						Problem("Entity set 'QuestRoomContext.QuestRooms'  is null.");
		}

		// GET: Admin/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null || _context.QuestRooms == null)
			{
				return NotFound();
			}

			var questRoom = await _context.QuestRooms
				.FirstOrDefaultAsync(m => m.Id == id);
			if (questRoom == null)
			{
				return NotFound();
			}

			return View(questRoom);
		}

		// GET: Admin/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Admin/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(CreateViewModel vM)
		{
			if (ModelState.IsValid)
			{

				string pictureName = vM.QuestRoom.QuestName.Dehumanize() + ".png";

				string path = $"{_hostingEnvironment.WebRootPath}\\images\\";
				using (Stream fileStream = new FileStream(path, FileMode.CreateNew))
				{

				}
				//_context.Add(vM.QuestRoom);
				//await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(vM);
		}

		// GET: Admin/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null || _context.QuestRooms == null)
			{
				return NotFound();
			}
			EditViewModel vM = new EditViewModel();
			vM.QuestRoom = await _context.QuestRooms.FindAsync(id);
			if (vM.QuestRoom == null)
			{
				return NotFound();
			}
			return View(vM);
		}

		// POST: Admin/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, EditViewModel vM)
		{
			if (id != vM.QuestRoom.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					string filePath = $"{_hostingEnvironment.WebRootPath}\\images\\{vM.QuestRoom.ImageName}";
					if (vM.Image is not null)
					{
						try
						{
							using (Stream fileStream = new FileStream(filePath, FileMode.Create))
							{
								await vM.Image.CopyToAsync(fileStream);
							}
						}
						catch (Exception ex)
						{
							_logger.LogError(ex.Message);
						}
					}
					_context.Update(vM.QuestRoom);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!QuestRoomExists(vM.QuestRoom.Id))
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
			return View(vM.QuestRoom);
		}

		// GET: Admin/Delete/5	
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null || _context.QuestRooms == null)
			{
				return NotFound();
			}

			var questRoom = await _context.QuestRooms
				.FirstOrDefaultAsync(m => m.Id == id);
			if (questRoom == null)
			{
				return NotFound();
			}

			return View(questRoom);
		}

		// POST: Admin/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			if (_context.QuestRooms == null)
			{
				return Problem("Entity set 'QuestRoomContext.QuestRooms' is null.");
			}
			var questRoom = await _context.QuestRooms.FindAsync(id);
			if (questRoom != null)
			{
				System.IO.File.Delete($"{_hostingEnvironment.WebRootPath}\\images\\{questRoom.ImageName}");
				_context.QuestRooms.Remove(questRoom);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool QuestRoomExists(int id)
		{
			return (_context.QuestRooms?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
