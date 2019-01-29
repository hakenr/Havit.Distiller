namespace Havit.Distiller.Model
{
	public class DistillationResponseItem
	{
		public int Id { get; set; }

		public DistillationResponseSet ResponseSet { get; set; }
		public int ResponseSetId { get; set; }

		public DistillationItem DistillationItem { get; set; }
		public int DistillationItemId { get; set; }

		public int ResponseValue { get; set; }
	}
}