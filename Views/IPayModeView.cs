using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IPayModeView
    {

        string playModeId { get; set; }
        string playModeName { get; set; }

        string playModeOservation { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        Action<object?, EventArgs> CancelEvent { get; set; }
        Action<object?, EventArgs> SaveEvent { get; set; }
        Action<object?, EventArgs> DeleteEvent { get; set; }
        Action<object?, EventArgs> EditEvent { get; set; }
        Action<object?, EventArgs> SearchEvent { get; set; }
        Action<object?, EventArgs> AddNewEvent { get; set; }

        void SetPayModeListBildingSource(BindingSource payModeList);
        void show();
    }
}
