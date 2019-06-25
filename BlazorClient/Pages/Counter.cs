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
                    stateService.OnStateChanged += () => StateHasChanged(); 
                }
            }
        }

        protected int currentCount => stateService.Counter;        

        protected override void OnAfterRender()
        {
            var timer = new System.Timers.Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            base.OnAfterRender();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            
        }

        protected void IncrementCount()
        {
            stateService.IncrementCounter();
        }
    }
}
