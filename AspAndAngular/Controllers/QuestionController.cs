using AspAndAngular.Core;
using AspAndAngular.Infrastructure.EntityFrameworkCore.repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_new_app.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]  
    public class QuestionController : ControllerBase
    {
        private readonly IquestionRepository _context;

        public QuestionController(IquestionRepository context)
        {
            _context = context;
        }

        [HttpGet]
        [ActionName("GetMaxQuestions")]
        public async Task<ActionResult<Question>> GetMaxQuestions()
        {
            int result = await _context.GetMaxQuestions();

            if (result <= 0)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("Id")]
        [ActionName("GetNextQuestion")]
        public async Task<ActionResult<Question>> GetNextQuestion(int Id)
        {
            Question question = await _context.GetQuestionById(Id);

            if (question == null)
            {
                return NotFound();
            }

            return Ok(question);
        }
    }
}
