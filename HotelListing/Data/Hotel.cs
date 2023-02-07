﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Data
{
    public class Hotel
    {
        public int Id { get; set; }//PK; EF Core increments this automatically
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }

        [ForeignKey(nameof(CountryID))]
        public int CountryID { get; set; }
        public Country Country { get; set; }
    }
}
