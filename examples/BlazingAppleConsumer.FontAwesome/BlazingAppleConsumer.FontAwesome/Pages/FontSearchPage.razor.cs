using BlazingApple.FontAwesome.Models;
using BlazingApple.FontAwesome.Services;
using Microsoft.AspNetCore.Components;

namespace BlazingAppleConsumer.FontAwesome.Pages
{
    public partial class FontSearchPage : ComponentBase
    {
        private IEnumerable<FontAwesomeIcon>? _icons;

        private string? _searchQuery;

        [Inject]
        private FontSearchService SearchService { get; set; } = null!;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _icons = await SearchService.Get();
        }

        private async Task Search()
        {
            _icons = await SearchService.Search(_searchQuery);
        }
    }
}
