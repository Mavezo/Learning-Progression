using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.NET_MVC_QuestRoom.Data.Entity;
using ASP.NET_MVC_QuestRoom.Models;

namespace ASP.NET_MVC_QuestRoom.Controllers
{
	public class QuestRoomsController : Controller
	{
		private readonly QuestRoomContext _context;

		public QuestRoomsController(QuestRoomContext context)
		{
			_context = context;
		}

		// GET: QuestRooms
		public async Task<IActionResult> Index(string? search)
		{
			IQueryable<QuestRoom> rooms = _context.QuestRooms;
			QuestIndexViewModel vM = new QuestIndexViewModel() { Rooms = rooms};
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

			return _context.QuestRooms != null ?
						View(vM) :
						Problem("Entity set 'QuestRoomContext.QuestRooms'  is null.");
		}

		// GET: QuestRooms/Details/5
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


	}
}
