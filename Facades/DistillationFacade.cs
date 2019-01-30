using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havit.Data.Patterns.DataLoaders;
using Havit.Data.Patterns.UnitOfWorks;
using Havit.Diagnostics.Contracts;
using Havit.Distiller.DataLayer.Repositories;
using Havit.Distiller.Model;
using Havit.Distiller.Shared;
using Havit.Extensions.DependencyInjection.Abstractions;

namespace Havit.Distiller.Facades
{
	[Service]
	public class DistillationFacade : IDistillationFacade
	{
		private readonly IDistillationResponseSetRepository distillationResponseSetRepository;
		private readonly IDistillationItemRepository distillationItemRepository;
		private readonly IDataLoader dataLoader;
		private readonly IUnitOfWork unitOfWork;

		public DistillationFacade(
			IDistillationItemRepository distillationItemRepository,
			IDistillationResponseSetRepository distillationResponseSetRepository,
			IDataLoader dataLoader,
			IUnitOfWork unitOfWork)
		{
			this.distillationResponseSetRepository = distillationResponseSetRepository;
			this.distillationItemRepository = distillationItemRepository;
			this.dataLoader = dataLoader;
			this.unitOfWork = unitOfWork;
		}

		public DistillationResponseSetDetailVM GetDistillationResponseSetDetail(string responseSetKey = null)
		{
			DistillationResponseSet responseSet = null;

			if (!String.IsNullOrWhiteSpace(responseSetKey))
			{
				responseSet = distillationResponseSetRepository.GetByKey(responseSetKey);

				if (responseSet != null)
				{
					dataLoader.Load(responseSet, rs => rs.Items);
				}
			}

			return new DistillationResponseSetDetailVM()
			{
				//Scopes =
				//{
				//	new DistillationScopeVM() { Id = 1, Name = "HAVIT" },
				//	new DistillationScopeVM() { Id = 2, Name = "Blue team" },
				//	new DistillationScopeVM() { Id = 3, Name = "Green team" },
				//	new DistillationScopeVM() { Id = 4, Name = "Yellow team" },
				//	new DistillationScopeVM() { Id = 5, Name = "Supportive team" },
				//	new DistillationScopeVM() { Id = 6, Name = "Management" },
				//},
				ResponseSetHeader = new DistillationResponseSetHeaderDto()
				{
					Comments = responseSet?.Comments,
					Submitter = responseSet?.Submitter,
				},
				DistillationItems = distillationItemRepository.GetAll().OrderBy(i => i.Text).Select(i => new DistillationItemVM()
				{
					Id = i.Id,
					Text = i.Text
				})
				.ToList(),
				ResponseItems = responseSet?.Items.Select(i => new DistillationResponseItemDto()
				{
					DistillationItemId = i.DistillationItemId,
					ResponseValue = i.ResponseValue
				})
				.ToList() ?? new List<DistillationResponseItemDto>()
			};
		}

		public void SubmitResponseSetItem(string responseSetKey, DistillationResponseItemDto responseItemIM)
		{
			Contract.Requires<ArgumentNullException>(responseItemIM != null, nameof(responseItemIM));
			Contract.Requires<ArgumentException>(!String.IsNullOrWhiteSpace(responseSetKey), nameof(responseSetKey));
			Contract.Requires<ArgumentException>(responseItemIM.ResponseValue != null, nameof(responseItemIM.ResponseValue));

			DistillationResponseSet responseSet = GetOrCreateResponseSet(responseSetKey);

			var responseItem = responseSet.Items.SingleOrDefault(i => i.DistillationItemId == responseItemIM.DistillationItemId);
			if (responseItem == null)
			{
				responseItem = new DistillationResponseItem()
				{
					ResponseSet = responseSet,
					DistillationItemId = responseItemIM.DistillationItemId
				};
				unitOfWork.AddForInsert(responseItem);
			}
			else
			{
				unitOfWork.AddForUpdate(responseItem);
			}

			responseItem.ResponseValue = responseItemIM.ResponseValue.Value;

			unitOfWork.Commit();
		}

		private DistillationResponseSet GetOrCreateResponseSet(string responseSetKey)
		{
			var responseSet = distillationResponseSetRepository.GetByKey(responseSetKey);

			if (responseSet != null)
			{
				dataLoader.Load(responseSet, rs => rs.Items);

				unitOfWork.AddForUpdate(responseSet);
			}
			else
			{
				responseSet = new DistillationResponseSet()
				{
					Key = responseSetKey
				};

				unitOfWork.AddForInsert(responseSet);
			}

			return responseSet;
		}

		public void UpdateResponseSetHeader(string responseSetKey, DistillationResponseSetHeaderDto responseSetHeaderIM)
		{
			Contract.Requires<ArgumentNullException>(responseSetHeaderIM != null, nameof(responseSetHeaderIM));

			DistillationResponseSet responseSet = GetOrCreateResponseSet(responseSetKey);

			responseSet.Comments = responseSetHeaderIM.Comments;
			responseSet.Submitter = responseSetHeaderIM.Submitter;

			unitOfWork.Commit();
		}
	}
}
