using System;
using System.Collections.Generic;

namespace Survey.Models
{
    public class SurveyForm
    {
        public string Question { get; set; }
        public List<string> Options { get; set; }

        public SurveyForm()
        {
        }
    }
}
