using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistance;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController(
        DataContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities() =>
            await context.Activities.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id) =>
            await context.Activities.FindAsync(id);
    }
}
