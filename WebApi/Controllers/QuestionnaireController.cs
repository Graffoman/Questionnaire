using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using Services.Contracts.QuestionnaireDto;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionnaireController : ControllerBase
    {
        private readonly IQuestionnaireService _service;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public QuestionnaireController(IQuestionnaireService service, ILogger<QuestionnaireController> logger, IMapper mapper)
        {
            _service = service;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var questionnaire = await _service.GetByIdAsync(id);
            return Ok(questionnaire);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var questionnaires = await _service.GetAllAsync();
            return Ok(questionnaires);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateQuestionnaireDto createQuestionnaireDto)
        {
            var id = await _service.CreateAsync(createQuestionnaireDto);
            return Ok(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(string id, UpdateQuestionnaireDto updateQuestionnaireDto)
        {
            var questionnaire = _mapper.Map<UpdateQuestionnaireDto, Questionnaire>(updateQuestionnaireDto);
            questionnaire.Id = id;

            await _service.UpdateAsync(questionnaire);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteByIdAsync(string id)
        {
            await _service.DeleteByIdAsync(id);
            return Ok();
        }
    }
}
