using Member.Application;
using Microsoft.AspNetCore.Mvc;

namespace Member.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MembersController : ControllerBase
{
    private readonly IMemberService _memberService;

    public MembersController(IMemberService memberService)
    {
        _memberService = memberService;
    }

    [HttpGet]
    public ActionResult<IList<Domain.Member>> Get()
    {
        return Ok(_memberService.GetAllMembers());
    }
}
