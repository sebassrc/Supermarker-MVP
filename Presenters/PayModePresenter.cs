using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket-mvp.Models;
using Supermarket-mvp.Views;

namespace Supermarket_mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeViews view;
        private IPayModeRepository repository;
        private Bindinsource payModeBindinsource;
        private IEnumerable<PayModeModel> payModeList;
    }
}
