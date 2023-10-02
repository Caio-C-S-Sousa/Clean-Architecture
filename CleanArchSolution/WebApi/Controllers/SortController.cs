using Application;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SortController
{
    public SortController()
    {

    }

    [HttpPost]
    public IEnumerable<int> Sort(int[] array)
    {
        var result = new SortService().BubbleSort(array);

        return result;
    }
}
