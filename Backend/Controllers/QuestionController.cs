using ApiFacade.QuestionFacade;
using DataModel;
using Facade.Core;
using Mapper;
using Microsoft.AspNetCore.Mvc;
using Service.QuestionService;

namespace Controllers;

[ApiController]
[Route("API/[controller]")]
public class QuestionController : ControllerBase, IQuestionFacade
{
    private readonly IQuestionService _questionService;

    public QuestionController(IQuestionService questionService)
    {
        _questionService = questionService;
    }

    [HttpPost]
    [Route("CreateMultipleChoiceQuestion")]
    public async Task<ActionResult<CreateMultipleChoiceQuestionRespond>> CreateMultipleChoiceQuestion([FromBody] CreateMultipleChoiceQuestionRequest request)
    {
        request.Validate();
        var question = await _questionService.CreateMultipleChoiceQuestion(request.ToDTO());
        return Ok(new CreateMultipleChoiceQuestionRespond(question.FromDTO()));
    }

    [HttpGet]
    [Route("GetQuestion")]
    public ActionResult<string> GetQuestion()
    {
        return null;
    }
}