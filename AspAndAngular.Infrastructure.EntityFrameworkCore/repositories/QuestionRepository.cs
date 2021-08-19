using AspAndAngular.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspAndAngular.Infrastructure.EntityFrameworkCore.repositories
{
    public class QuestionRepository : IquestionRepository
    {
        private readonly ApplicationDbContext _context;

        public QuestionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<int> GetMaxQuestions()
        {
            var count =_context.Questions.Count();

            return Task.FromResult(count);
        }

        public async Task<Question> GetQuestionById(int id)
        {
            var question = await _context.Questions
                .Include(q => q.Answers)
                .Include(q => q.CorrectAnswer)
                .FirstOrDefaultAsync(q => q.Id == id);

            return question;
        }
    }
}
