﻿using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ServiceInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Models.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Presenters
{
    public class HistoryPresenter
    {
        private IHistoryFormView _view;
        private IHistoryService _model;

        public HistoryPresenter (IHistoryFormView view) 
        {
            _view = view;
            _model = new HistoryService();
        }
        public event Action<string> OnSelectSellNumberError;
        public event Action<string> OnSelectRefundNumberError;
        public IEnumerable<ISellInfo> FindSalesByDates()
        {
            return _model.FindSalesByDates(_view.SellInfoDateFrom.Date, _view.SellInfoDateTo.Date);
        }
        public IEnumerable<IRefundInfo> FindRefundsByDates()
        {
            return _model.FindRefundsByDates(_view.RefundInfoDateFrom.Date, _view.RefundInfoDateTo.Date);
        }
        public IEnumerable<IRevenue> FindRevenuesByDates()
        {
            return _model.FindRevenuesByDates(_view.RevenueDateFrom.Date, _view.RevenueDateTo.Date);
        }
        public IEnumerable<IProductsCollectionItem>? FindProductsBySelectedSellNumber()
        {
            try
            {
                return _model.FindProductsBySelectedSellNumber(_view.SelectSellNumber);
            }
            catch (ArgumentException ex)
            {
                OnSelectSellNumberError.Invoke(ex.Message);
                return null;
            }
        }
        public IEnumerable<IProductsCollectionItem>? FindProductsBySelectedRefundNumber()
        {
            try
            {
                _view.Reason = _model.GetReason(_view.SelectRefundNumber);
                return _model.FindProductsBySelectedRefundNumber(_view.SelectRefundNumber);
            }
            catch (ArgumentException ex)
            {
                OnSelectRefundNumberError.Invoke(ex.Message);
                return null;
            }

}

    }
}
