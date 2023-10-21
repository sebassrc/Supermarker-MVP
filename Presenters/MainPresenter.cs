﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using Supermarket_mvp.Repositories;
using System.Runtime.CompilerServices;

namespace Supermarket_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public  MainPresenter(IMainView mainView, string sqlConnectionString) 
        {

                this.mainView = mainView;
                this.sqlConnectionString = sqlConnectionString;


                this.mainView.ShowProductView += ShowProductView;
        }

        private void ShowProductView(object? sender, EventArgs e)
        {
            IPayModeView view = new PayModeView();
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);


        }
    }
}
