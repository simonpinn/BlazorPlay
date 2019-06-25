using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClient.Services
{
    public interface IAppStateService
    {
        event AppStateServiceEvent OnStateChanged;
        int Counter { get; }
        void IncrementCounter();
    }

    public delegate void AppStateServiceEvent();

    public class AppStateService : IAppStateService
    {
        public event AppStateServiceEvent OnStateChanged;

        public AppStateService()
        {
            var timer = new System.Timers.Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            IncrementCounter();
            OnStateChanged();
        }

        public int Counter { get; private set; }
        public void IncrementCounter()
        {
            Counter++;
        }
    }
}
