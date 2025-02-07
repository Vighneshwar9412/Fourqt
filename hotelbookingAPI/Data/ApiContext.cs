﻿using Microsoft.EntityFrameworkCore;
using hotelbookingAPI.Models;

namespace hotelbookingAPI.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<HotelBooking> Bookings { get; set; }
        public  ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
            {

            }
    }
}
