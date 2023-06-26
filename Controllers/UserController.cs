using System;
using System.Collections.Generic;
using EF7CodeFirst.Services;
using Microsoft.AspNetCore.Mvc;

namespace EF7CodeFirst.Controllers
{
	[Route("api/Controller")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;
		public UserController(IVehicleService userService)
		{
			_userService = (IUserService?)userService;
		}

		[HttpGet]

	}
}

