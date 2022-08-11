using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NGUYENQUOCTUAN_1340_IS385AIS_DOANCANHAN.App_Code
{
    public class CartItem
    {
        private int idsanpham;
        private String tensanpham;
        private double dongia;
        private int soluong;
        private String hinhanh;
        public int IDSANPHAM
        {
            set { this.idsanpham = value; }
            get { return this.idsanpham; }
        }
        public String TENSANPHAM
        {
            set { this.tensanpham = value; }
            get { return this.tensanpham; }
        }
        public double DONGIA
        {
            set { this.dongia = value; }
            get { return this.dongia; }
        }
        public int SOLUONG
        {
            set { this.soluong = value; }
            get { return this.soluong; }
        }
        public String HINHANH
        {
            set { this.hinhanh = value; }
            get { return this.hinhanh; }
        }
        public double THANHTIEN
        {
            get { return (this.soluong * this.dongia); }
        }
        public CartItem()
        { }
        public CartItem(int idsanpham, String tensanpham, double dongia, int soluong, String hinhanh)
        {
            this.idsanpham = idsanpham;
            this.tensanpham = tensanpham;
            this.dongia = dongia;
            this.soluong = soluong;
            this.hinhanh = hinhanh;
        }
    }
}