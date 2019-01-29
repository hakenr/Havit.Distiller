using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havit.Distiller.Shared
{
    public class DistillationResponseSetDto
    {
		public string Comments { get; set; }

		public List<DistillationResponseItemDto> Items { get; set; } = new List<DistillationResponseItemDto>();
	}
}
