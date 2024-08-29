using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using Services.Contracts.QuestionnaireSubmitDto;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionnaireSubmitController : ControllerBase
    {
        private readonly IQuestionnaireSubmitService _service;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public QuestionnaireSubmitController(IQuestionnaireSubmitService service, ILogger<QuestionnaireSubmitController> logger, IMapper mapper)
        {
            _service = service;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var questionnaireSubmit = await _service.GetByIdAsync(id);
            return Ok(questionnaireSubmit);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var questionnaireSubmits = await _service.GetAllAsync();
            return Ok(questionnaireSubmits);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateQuestionnaireSubmitDto createQuestionnaireSubmitDto)
        {
            var id = await _service.CreateAsync(createQuestionnaireSubmitDto);
            return Ok(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(string id, UpdateQuestionnaireSubmitDto updateQuestionnaireSubmitDto)
        {
            var questionnaireSubmit = _mapper.Map<UpdateQuestionnaireSubmitDto, QuestionnaireSubmit>(updateQuestionnaireSubmitDto);
            questionnaireSubmit.Id = id;

            await _service.UpdateAsync(questionnaireSubmit);
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
