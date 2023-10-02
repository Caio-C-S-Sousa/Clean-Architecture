using Core;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using System.Net.Mail;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SortController
{
    private readonly ISortService _sortService;
    private readonly IEmailService _emailService;

    public SortController(ISortService sortService, IEmailService emailService)
    {
        _sortService = sortService;
        _emailService = emailService;
    }

    [HttpPost]
    public IEnumerable<int> Sort(int[] array)
    {
        var result = _sortService.BubbleSort(array);

        _emailService.SendEmail("sort@course.com", string.Join(", ", result.ToArray()));

        return result;
    }
}
