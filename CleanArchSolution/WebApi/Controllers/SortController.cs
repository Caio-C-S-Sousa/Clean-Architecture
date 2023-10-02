using Core;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SortController
{
    private readonly ISortService _sortService;

    public SortController(ISortService sortService)
    {
        _sortService = sortService;
    }

    [HttpPost]
    public IEnumerable<int> Sort(int[] array)
    {
        var result = _sortService.BubbleSort(array);

        return result;
    }
}
