using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.NET_MVC_9.Data.Entity;
using ASP.NET_MVC_9.Models.CatViewModels;
using ASP.NET_MVC_9.Models.DTO;
using AutoMapper;

namespace ASP.NET_MVC_9.Controllers
{
	public class CatsController : Controller
	{
		private readonly CatContext _context;
		private readonly IMapper _mapper;
		private readonly ILogger _logger;

		public CatsController(CatContext context, ILoggerFactory loggerFactory, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
			_logger = loggerFactory.CreateLogger<CatContext>();
		}

		// GET: Cats
		public async Task<IActionResult> Index(int breedId, string? search)
		{
			IQueryable<Cat> cats = _context.Cats.Include(c => c.Breed).Where(t => t.IsDeleted == false);
			if (breedId > 0)
			{
				cats = cats.Where(t => t.BreedId == breedId);
			}
			if (search is not null)
			{
				cats = cats.Where(t => t.CatName.Contains(search));
			}
			IQueryable<Breed> breeds = _context.Breeds;
			SelectList breedSL = new SelectList(await breeds.ToListAsync(),
				dataValueField: nameof(Breed.Id),
				dataTextField: nameof(Breed.BreedName),
				selectedValue: breedId);

			IEnumerable<CatDTO> tempCats = _mapper.Map<IEnumerable<CatDTO>>(await cats.ToListAsync());

			//var tempCats = await cats.Select(t => new CatDTO{
			//	//Mapping (projection) Cat to CatDTO
			//	Id = t.Id,
			//	CatName = t.CatName,
			//	Description = t.Description,
			//	IsVacinated =t.IsVacinated,
			//	CatGender = t.CatGender,
			//	BreedId = t.BreedId,
			//	Image = t.Image,
			//	Breed = new BreedDTO
			//	{
			//		Id = t.Breed.Id,
			//		BreedName = t.Breed.BreedName
			//	}
			//}).ToListAsync();

			IndexCatViewModel vM = new IndexCatViewModel()
			{
				Cats = tempCats,
				BreedSL = breedSL,
				BreedId = breedId,
				Search = search
			};
			return View(vM);
		}

		// GET: Cats/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null || _context.Cats == null)
			{
				return NotFound();
			}

			var cat = await _context.Cats
				.Include(c => c.Breed)
				.FirstOrDefaultAsync(m => m.Id == id);
			if (cat == null)
			{
				return NotFound();
			}
			DetailsCatVIewModel vM = new DetailsCatVIewModel()
			{
				Cat = cat
			};
			return View(vM);
		}

		// GET: Cats/Create
		public IActionResult Create()
		{
			//ViewData["BreedId"] = new SelectList(_context.Breeds, "Id", "BreedName");
			CreateCatViewModel vM = new CreateCatViewModel
			{
				BreedSL = new SelectList(_context.Breeds, "Id", "BreedName")
			};
			return View(vM);
		}

		// POST: Cats/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(CreateCatViewModel vM)
		{
			if (!ModelState.IsValid)
			{
				SelectList breedSL = new SelectList(await _context.Breeds.ToListAsync(),
					nameof(Breed.Id),
					nameof(Breed.BreedName),
					vM.Cat.BreedId);
				vM.BreedSL = breedSL;
				foreach (var error in ModelState.Values.SelectMany(t => t.Errors))
				{
					_logger.LogError(error.ErrorMessage);
				}
				return View(vM);
			}
			byte[] buff = null;
			using (BinaryReader br = new BinaryReader(vM.Image.OpenReadStream()))
			{
				vM.Cat.Image = br.ReadBytes((int)vM.Image.Length);
			}
			Cat createdCat = _mapper.Map<Cat>(vM.Cat);
			_context.Add(createdCat);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		// GET: Cats/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null || _context.Cats == null)
			{
				return NotFound();
			}

			var cat = await _context.Cats.FindAsync(id);
			if (cat == null)
			{
				return NotFound();
			}
			IQueryable<Breed> breeds = _context.Breeds;
			SelectList breedSL = new SelectList(await breeds.ToListAsync(), nameof(Breed.Id), nameof(Breed.BreedName), cat.BreedId);
			EditCatViewModel vM = new EditCatViewModel()
			{
				BreedSL = breedSL,
				Cat = _mapper.Map<CatDTO>(cat),
			};

			return View(vM);
		}

		// POST: Cats/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, EditCatViewModel vM)
		{
			if (id != vM.Cat.Id)
			{
				return NotFound();
			}

			if (!ModelState.IsValid)
			{
				foreach (var error in ModelState.Values.SelectMany(t => t.Errors))
				{
					_logger.LogError(error.ErrorMessage);
				}
				SelectList breedSL = new SelectList(await _context.Breeds.ToListAsync(),
			   nameof(Breed.Id),
			   nameof(Breed.BreedName),
			   vM.Cat.BreedId);
				vM.BreedSL = breedSL;
				return View(vM);
			}
			try
			{
				if (vM.Image is not null)
				{
					using (BinaryReader br = new BinaryReader(vM.Image.OpenReadStream()))
					{
						vM.Cat.Image = br.ReadBytes((int)vM.Image.Length);
					}
				}
				Cat editedCat = _mapper.Map<Cat>(vM.Cat);
				_context.Update(editedCat);
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!CatExists(vM.Cat.Id))
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

		// GET: Cats/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null || _context.Cats == null)
			{
				return NotFound();
			}

			var cat = await _context.Cats
				.Include(c => c.Breed)
				.FirstOrDefaultAsync(m => m.Id == id);
			if (cat == null)
			{
				return NotFound();
			}

			return View(cat);
		}

		// POST: Cats/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			if (_context.Cats == null)
			{
				return Problem("Entity set 'CatContext.Cats'  is null.");
			}
			var cat = await _context.Cats.FindAsync(id);
			if (cat != null)
			{
				_context.Cats.Remove(cat);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> List(string breedName)
		{
			IQueryable<Cat> cats;
			if (breedName != String.Empty && breedName is not null)	
				cats = _context.Cats.Include(t => t.Breed).Where(t => t.Breed.BreedName == breedName);
			else
				cats = _context.Cats.Include(t => t.Breed);
			return View(cats);
		}


		private bool CatExists(int id)
		{
			return (_context.Cats?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
