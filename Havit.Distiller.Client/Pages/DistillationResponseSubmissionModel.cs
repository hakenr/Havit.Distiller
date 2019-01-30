using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;
using Havit.Distiller.Shared;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;

namespace Havit.Distiller.Client.Pages
{
    public class DistillationResponseSubmissionModel : BlazorComponent
    {
		[Inject]
		public HttpClient Http { get; set; }

		[Inject]
		public LocalStorage LocalStorage { get; set; }

		protected DistillationResponseSetDetailVM ViewModel { get; set; }
		protected Dictionary<int, DistillationResponseItemDto> ResponseItemsByDistillationItemId { get; set; }
		protected string ResponseSetKey { get; set; }
		protected DistillationResponseSetHeaderDto Header { get; set; }

		protected override async Task OnInitAsync()
		{
			if (LocalStorage["ResponseSetKey"] is null)
			{
				LocalStorage["ResponseSetKey"] = Guid.NewGuid().ToString();
			}

			ResponseSetKey = LocalStorage["ResponseSetKey"];

			await LoadViewModel();
		}

		private async Task LoadViewModel()
		{
			ViewModel = await Http.GetJsonAsync<DistillationResponseSetDetailVM>($"/api/distillation/responseset/{ResponseSetKey}");

			Header = ViewModel.ResponseSetHeader ?? new DistillationResponseSetHeaderDto();
			ResponseItemsByDistillationItemId = ViewModel.ResponseItems.ToDictionary(i => i.DistillationItemId);
		}

		protected async Task Vote(int itemId, int responseValue)
		{
			DistillationResponseItemDto item = null;

			if (ResponseItemsByDistillationItemId.TryGetValue(itemId, out item))
			{
				item.ResponseValue = responseValue;
			}
			else
			{
				item = new DistillationResponseItemDto()
				{
					DistillationItemId = itemId,
					ResponseValue = responseValue
				};
				ResponseItemsByDistillationItemId[itemId] = item;
			}

			await Http.PostJsonAsync($"/api/distillation/responseset/{ResponseSetKey}/items/{itemId}", item);
		}

		protected int? GetVote(int itemId)
		{
			ResponseItemsByDistillationItemId.TryGetValue(itemId, out var responseItem);

			return responseItem?.ResponseValue;
		}

		protected async Task OnResponseSetKeyChange(UIChangeEventArgs args)
		{
			LocalStorage["ResponseSetKey"] = args.Value.ToString();
			this.ResponseSetKey = args.Value.ToString();

			await LoadViewModel();
		}

		protected async Task OnHeaderSubmitClick()
		{
			await Http.PostJsonAsync($"/api/distillation/responseset/{ResponseSetKey}/header", this.Header);
		}
	}
}
