﻿namespace CourseWorkWF
{
    public class ProductListItem
    {
        private IProduct _product;
        private decimal _amount;
        public IProduct Product
        {
            get { return _product; }
            set { if (value == null) throw new ArgumentNullException("Попытка присвоить значение null в _product"); _product = value; }
        }
        public decimal Amount
        {
            get { return _amount; }
            set { if (value < 0) throw new AccessViolationException("Количество продукта не может быть отрицательно"); _amount = value; }
        }
        public ProductListItem(IProduct product, decimal amount)
        {
            Product = product;
            Amount = amount;
        }   
    }
}
