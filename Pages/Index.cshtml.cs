using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MediatR;
using TestCaseElevator.Services.Dto.DtoElevatorIndoorControllerService;
using TestCaseElevator.Services.Dto.DtoElevatorOutdoorControllerService;

namespace TestCaseElevator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public string Action { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
    }
}
