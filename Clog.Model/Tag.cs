using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clog.Model
{
	public class Tag
	{
		public int TagId { get; set; }
		public string Name { get; set; }
		public int Color { get; set; }

		public virtual ICollection<Log> Logs { get; set; }
	}
}
