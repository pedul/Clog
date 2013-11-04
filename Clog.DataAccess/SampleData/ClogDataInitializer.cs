using Clog.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clog.Data.SampleData
{
	class ClogDataInitializer : DropCreateDatabaseIfModelChanges<ClogContext>
	{
		protected override void Seed(ClogContext context)
		{
			AddQuestionAnswers(context);

			context.SaveChanges();

			base.Seed(context);
		}

		private void AddQuestionAnswers(ClogContext context)
		{
			var qa = new QuestionAnswer()
					{
						Question = "What is the purpose of the provider ?",
						Answer = "Don't know."
					};
			context.QuestionAnswerLogs.Add(qa);

			qa = new QuestionAnswer()
				{
					Question = "Sample question",
					Answer = null
				};
			context.QuestionAnswerLogs.Add(qa);
		}
	}
}
