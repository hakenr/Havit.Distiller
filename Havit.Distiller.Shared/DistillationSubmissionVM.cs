using System.Collections.Generic;

namespace Havit.Distiller.Shared
{
	public class DistillationSubmissionVM
	{
		//public List<DistillationScopeVM> Scopes { get; set; } = new List<DistillationScopeVM>();

		public List<DistillationItemVM> DistillationItems { get; set; } = new List<DistillationItemVM>();

		public List<DistillationResponseItemDto> ResponseItems { get; set; } = new List<DistillationResponseItemDto>();
	}
}