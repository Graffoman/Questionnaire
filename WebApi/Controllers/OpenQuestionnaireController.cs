using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using Services.Contracts.OpenQuestionnaireDto;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenQuestionnaireController : ControllerBase
    {
        private readonly IOpenQuestionnaireService _service;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public OpenQuestionnaireController(IOpenQuestionnaireService service, ILogger<OpenQuestionnaireController> logger, IMapper mapper)
        {
            _service = service;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var openQuestionnaire = await _service.GetByIdAsync(id);
            return Ok(openQuestionnaire);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var openQuestionnaires = await _service.GetAllAsync();
            return Ok(openQuestionnaires);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateOpenQuestionnaireDto createOpenQuestionnaireDto)
        {
            var id = await _service.CreateAsync(createOpenQuestionnaireDto);
            return Ok(id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteByIdAsync(string id)
        {
            await _service.DeleteByIdAsync(id);
            return Ok();
        }
    }
}
