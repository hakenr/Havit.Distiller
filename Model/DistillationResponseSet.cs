using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havit.Distiller.Model
{
    public class DistillationResponseSet
    {
        public int Id { get; set; }

		[MaxLength(100)]
		// TODO UniqueIndex
		public string Key { get; set; }

		public DistillationScope Scope { get; set; }
		public int? ScopeId { get; set; }

		[MaxLength(100)]
		public string Submitter { get; set; }

		[MaxLength]
		public string Comments { get; set; }

		public List<DistillationResponseItem> Items { get; } = new List<DistillationResponseItem>();

		public DateTime Created { get; set; }
	}
}
