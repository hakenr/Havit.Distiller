using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havit.Diagnostics.Contracts;
using Havit.Distiller.Facades;
using Havit.Distiller.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Havit.Distiller.Server.Controllers
{
    public class DistillationController : ControllerBase
	{
		private readonly IDistillationFacade distillationFacade;

		public DistillationController(IDistillationFacade distillationFacade)
		{
			this.distillationFacade = distillationFacade;
		}

		[HttpGet("/api/distillation/responseset/{responseSetKey}")]
		public DistillationResponseSetDetailVM GetDistillationSubmissionData(string responseSetKey)
		{
			return distillationFacade.GetDistillationResponseSetDetail(responseSetKey);
		}

		[HttpPost("api/distillation/responseset/{responseSetKey}/items/{distillationItemId:int}")]
		public void SubmitResponseSetItem(string responseSetKey, int distillationItemId, DistillationResponseItemDto responseItemIM)
		{
			Contract.Requires<ArgumentNullException>(responseItemIM != null, nameof(responseItemIM));
			Contract.Requires<ArgumentException>(responseItemIM.DistillationItemId == distillationItemId, nameof(distillationItemId));

			distillationFacade.SubmitResponseSetItem(responseSetKey, responseItemIM);
		}

		[HttpPost("api/distillation/responseset/{responseSetKey}/header")]
		public void SubmitResponseSetItem(string responseSetKey, DistillationResponseSetHeaderDto responseSetHeaderIM)
		{
			Contract.Requires<ArgumentNullException>(responseSetHeaderIM != null, nameof(responseSetHeaderIM));

			distillationFacade.UpdateResponseSetHeader(responseSetKey, responseSetHeaderIM);
		}

	}
}
