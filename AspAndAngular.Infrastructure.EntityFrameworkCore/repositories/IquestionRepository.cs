using AspAndAngular.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspAndAngular.Infrastructure.EntityFrameworkCore.repositories
{
    public interface IquestionRepository
    {
        public Task<int> GetMaxQuestions();
        public Task<Question> GetQuestionById(int id);
    }
}
