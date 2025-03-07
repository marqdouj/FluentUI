using Microsoft.JSInterop;

namespace Marqdouj.FluentUI
{
    internal class SlideshowJs(IJSRuntime jsRuntime) : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask = new(() =>
            jsRuntime.InvokeAsync<IJSObjectReference>(
            "import", "./_content/Marqdouj.FluentUI/Slideshow.js").AsTask());

        public async ValueTask LogToConsole(string text)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("logToConsole", text);
        }

        public async ValueTask Initialize()
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("initialize");
        }

        public async ValueTask PlusSlides(int direction)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("plusSlides", direction);
        }

        public async ValueTask CurrentSlide(int index)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("currentSlide", index);
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}
