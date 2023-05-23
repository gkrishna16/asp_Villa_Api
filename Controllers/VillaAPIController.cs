using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Magic_Villa_VillaAPI.Models;

namespace Magic_Villa_VillaAPI.Controllers
{
	[Route("api/VillaAPI")]
	[ApiController]
	public class VillaAPIController:ControllerBase
	{
		public IEnumerable <VillaDTO> GetVillas()
			{
			return new List<VillaDTO>
			{
				new VillaDTO{Id = 1, Name = "Pool View"},
				new VillaDTO{Id =2, Name = "Beach View2"}

			};
		}
	}
}

