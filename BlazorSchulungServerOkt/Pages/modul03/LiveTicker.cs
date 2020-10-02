using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchulungServerOkt.Pages.modul03
{
    public class LiveTicker
    {
        public List<TickerEintrag> TickerListe { get; set; }
        public event Action OnPropertyChanged;

        public LiveTicker()
        {
            TickerListe = new List<TickerEintrag>();
        }
        public TickerEintrag Add(string Text)
        {
            var t = new TickerEintrag();
            t.ID = TickerListe.Count() + 1;
            t.Text = Text;
            t.Zeit = DateTime.Now;
            TickerListe.Add(t);
            OnPropertyChanged?.Invoke();
            return t;

        }
    }
    public class TickerEintrag
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Zeit { get; set; }

    }
}
