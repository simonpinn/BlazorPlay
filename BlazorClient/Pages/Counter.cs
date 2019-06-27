using Microsoft.AspNetCore.Components;
using BlazorClient.Services;

namespace BlazorClient.Pages
{
    public class Counter_ : ComponentBase
    {
        private IAppStateService stateService;

        [Inject]
        protected IAppStateService StateService
        {
            get
            {
                return stateService;
            }
            set
            {
                stateService = value;
                if (stateService != null)
                {
                    stateService.OnStateChanged += () =>
                    {
                        CurrentCount = stateService.Counter;
                        StateHasChanged();
                    };
                }
            }
        }

        protected int CurrentCount { get; set; }

        protected void IncrementCount()
        {
            stateService.IncrementCounter();
        }        
    }
}
