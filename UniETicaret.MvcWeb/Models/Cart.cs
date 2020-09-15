using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniETicaret.MvcWeb.Entity;

namespace UniETicaret.MvcWeb.Models
{
    public class Cart
    {
        private List<CartLine> _cardLines = new List<CartLine>();

        public List<CartLine> CartLines
        {
            get { return _cardLines; }
        }

        public void AddProduct(Urun urun, int quantity)
        {
            var line = _cardLines.FirstOrDefault(i => i.Urun.Id == urun.Id);
            if (line == null)
            {
                _cardLines.Add(new CartLine() { Urun = urun, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void DeleteProduct(Urun urun)
        {
            _cardLines.RemoveAll(i => i.Urun.Id == urun.Id);
        }

        public double Total()
        {
            return _cardLines.Sum(i => i.Urun.Fiyat * i.Quantity);
        }

        public void Clear()
        {
            _cardLines.Clear();
        }
    }

    public class CartLine
    {
        public Urun Urun { get; set; }
        public int Quantity { get; set; }
    }
}