using Havit.Distiller.Shared;

namespace Havit.Distiller.Facades
{
	public interface IDistillationFacade
	{
		DistillationResponseSetDetailVM GetDistillationResponseSetDetail(string responseSetKey);
		void SubmitResponseSetItem(string responseSetKey, DistillationResponseItemDto responseItemIM);
		void UpdateResponseSetHeader(string responseSetKey, DistillationResponseSetHeaderDto responseSetHeaderIM);
	}
}