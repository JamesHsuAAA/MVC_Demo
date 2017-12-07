using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Demo.ViewModel
{
    public class Store
    {
        public string HeadCode { get; set; }

        [Key]
        public string StoreCode { get; set; }

        public string UnitCode { get; set; }

        public string StoreName { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public string StoreZip { get; set; }

        public string StoreAddress { get; set; }

        public string StoreTel { get; set; }

        public string StoreFax { get; set; }

        public string StoreEmail { get; set; }

        public string StoreCompany { get; set; }

        public string StoreInvoice { get; set; }

        public string StoreIP1 { get; set; }

        public string StoreIP2 { get; set; }

        public string StoreIP3 { get; set; }

        public string StoreIP4 { get; set; }

        public string StoreIP5 { get; set; }

        public string Image01 { get; set; }

        public int Image01W { get; set; }

        public int Image01H { get; set; }

        public string Image02 { get; set; }

        public int Image02W { get; set; }

        public int Image02H { get; set; }

        public string Image03 { get; set; }

        public int Image03W { get; set; }

        public int Image03H { get; set; }

        public string Image04 { get; set; }

        public int Image04W { get; set; }

        public int Image04H { get; set; }

        public string Image05 { get; set; }

        public int Image05W { get; set; }

        public int Image05H { get; set; }

        public string Memo { get; set; }

        public string Note1 { get; set; }

        public string Note2 { get; set; }

        public string Note3 { get; set; }

        public string Note4 { get; set; }

        public string Zone { get; set; }

        public string PayMode1 { get; set; }

        public string PayMode2 { get; set; }

        public string PayMode3 { get; set; }

        public byte Status { get; set; }

        public DateTime CDate { get; set; }

        public string UUid { get; set; }

        public DateTime UDate { get; set; }

        public double? GoogleMapLongi { get; set; }

        public double? GoogleMapLati { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string KeyWords { get; set; }

        public DateTime? ContractDate { get; set; }

        public DateTime? AuthorizeEnd { get; set; }

        public string AreaNo { get; set; }

        public string HighAreaNo { get; set; }

        public DateTime? FirstDate { get; set; }

        public DateTime? BusinessDate { get; set; }

        public DateTime? GeneralDeliveryDate { get; set; }

        public DateTime? ContractDeliveryDate { get; set; }

        public string DeliveryAddress { get; set; }

        public string IsDirect { get; set; }

    }
}