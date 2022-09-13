using Microsoft.AspNetCore.Mvc;

namespace Interview.Controllers;

[ApiController]
[Route("api/food")]
public class FoodController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(Foods);
    }

    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        Food food = Foods.First(x => x.Id == id);
        return Ok(food);
    }

    [HttpPost]
    public IActionResult Post(Food food)
    {
        food.Id = Guid.NewGuid();
        Foods.Add(food);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        Food food = Foods.First(x => x.Id == id);
        Foods.Remove(food);
        return Ok();
    }

    private static readonly List<Food> Foods = new();
}