using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clog.Model
{
	public abstract class Log
	{
		public int LogID { get; set; }
		public ICollection<Tag> Tags { get; set; }
	}
}
