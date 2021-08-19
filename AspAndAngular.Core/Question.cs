using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspAndAngular.Core
{
    public class Question
    {
        public int Id { get; set; }
        public string ActualQuestion { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
        public Answer CorrectAnswer { get; set; }
        public ChapterEnum Chapter { get; set; }
    }
}
