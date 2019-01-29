using Havit.Distiller.Shared;

namespace Havit.Distiller.Facades
{
	public interface IDistillationFacade
	{
		DistillationSubmissionVM GetDistillationSubmissionData(string responseSetKey);
		DistillationResponseSetDto GetResponseSet(string responseSetKey);
		void SubmitResponseSetItem(string responseSetKey, DistillationResponseItemDto responseItemIM);
	}
}