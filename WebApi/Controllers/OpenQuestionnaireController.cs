using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RabbitMQ.Abstractions;
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
        private readonly IRabbitMqProducer _rabbitMqProducer;

        public OpenQuestionnaireController(IOpenQuestionnaireService service, ILogger<OpenQuestionnaireController> logger, IMapper mapper, IRabbitMqProducer rabbitMqProducer)
        {
            _service = service;
            _logger = logger;
            _mapper = mapper;
            _rabbitMqProducer = rabbitMqProducer;
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
            var notification = new Notification()
            {
                MessageText = "Добрый день, пройдите пожалуйста по ссылке, чтобы пройти опрос.",
                OpenQuestionnaireUrl = $"http://localhost:5286/openquestionnaires/{id}",
                UserId = "Curent_Postgres_UserId"
            };
            var message = JsonConvert.SerializeObject(notification);
            _rabbitMqProducer.SendMessage(message);

            return Ok(id);
        }

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateAsync(string id, UpdateOpenQuestionnaireDto updateOpenQuestionnaireDto)
		{
			var openQuestionnaire = _mapper.Map<UpdateOpenQuestionnaireDto, OpenQuestionnaire>(updateOpenQuestionnaireDto);
			openQuestionnaire.Id = id;

			await _service.UpdateAsync(openQuestionnaire);
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
