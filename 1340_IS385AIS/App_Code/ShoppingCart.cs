using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
#pragma warning disable 0436
namespace NGUYENQUOCTUAN_1340_IS385AIS_DOANCANHAN.App_Code
{
    public class ShoppingCart
    {
        Dictionary<int, CartItem> Carts;
        public Dictionary<int, CartItem> CARTS
        {
            get { return this.Carts; }
        }
        public ShoppingCart()
        {
            this.Carts = new Dictionary<int, CartItem>();
        }
        public void Additem(int idsanpham, String tensanpham, double dongia, int soluong, String hinhanh)
        {
            if (Carts.ContainsKey(idsanpham))
                Carts[idsanpham].SOLUONG += Carts[idsanpham].SOLUONG + soluong;
            else
            {
                CartItem item = new CartItem(idsanpham, tensanpham, dongia, soluong, hinhanh);
                Carts.Add(idsanpham, item);
            }
        }
        public bool Deleteitem(int idsanpham)
        {
            return Carts.Remove(idsanpham);
        }
        public void DeleteAll()
        {
            Carts.Clear();
        }
        public CartItem FindItem(int idsanpham)
        {
            if (Carts.ContainsKey(idsanpham))
                return Carts[idsanpham];
            else
                return null;
        }
        public double TotalBill()
        {
            double toltal = 0;
            foreach (CartItem item in Carts.Values)
                toltal += item.THANHTIEN;
            return toltal;
        }
    }
}