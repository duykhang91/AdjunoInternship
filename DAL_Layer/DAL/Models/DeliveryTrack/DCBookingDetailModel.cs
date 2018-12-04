using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DAL_Layer.DAL.Models.OrderTrack;
using DAL_Layer.DAL.Models.ShipmentTrack;

namespace DAL_Layer.DAL.Models.DeliveryTrack
{
    public class DCBookingDetailModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        public string Line { get; set; }

        public int Quantity { get; set; }

        public int Cartons { get; set; }

        public decimal Cube { get; set; }

        [StringLength(50)]
        public string Item { get; set; }

        //[ForeignKey("Order")]
        public int OrderId { get; set; }

        //[ForeignKey("ManifestModel")]
        public string Container { get; set; }

        //[ForeignKey("DCBookingModel")]
        public int DCBookingId { get; set; }

        public virtual OrderModel Order { get; set; }

        //public virtual ManifestModel ManifestModel  { get; set; }

        public virtual DCBookingModel DCBooking { get; set; }


    }
}