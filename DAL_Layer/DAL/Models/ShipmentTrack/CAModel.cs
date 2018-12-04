﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DAL_Layer.DAL.Models.ShipmentTrack
{
    public class CAModel
    {
        [Key]
        public int Id { get; set; }
        //[ForeignKey("BookingModel")]
        public int BookingId { get; set; }
        public DateTime ArrivalDate { get; set; }

        [StringLength(20)]
        public string UpdatedBy { get; set; }

        public virtual BookingModel Booking { get; set; }
    }
}