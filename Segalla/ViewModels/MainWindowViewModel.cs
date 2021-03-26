using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Segalla.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public string UsuarioLogado { get; set; }
        public string DataSistema { get; set; }

        private DispatcherTimer Timer;
        public MainWindowViewModel() 
        {
            Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromSeconds(1);
            Timer.Tick += (s,e) => { 
                var Date = DateTime.Now; 
                DataSistema = $"{Date.ToLongDateString()} - {Date.Hour:00}:{Date.Minute:00}:{Date.Second:00}";
            };
            Timer.Start();
        }
    }
}
