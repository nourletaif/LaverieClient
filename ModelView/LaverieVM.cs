using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaverieClient.ModelView
{
    internal class LaverieVM
    {
        public ObservableCollection<Laverie> Laveries { get; set; }

        public LaverieVM()
        {
            // Simulated data for UI testing
            Laveries = new ObservableCollection<Laverie>
            {
                new Laverie(1, "Laverie Sunshine", "123 Main St"),
                new Laverie(2, "Quick Wash", "456 Elm St"),
                new Laverie(3, "Sparkling Clean", "789 Oak St")
            };
        }
    }
}
