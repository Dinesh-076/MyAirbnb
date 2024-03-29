﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAirbnb.Models
{
    public class ApplicationUser : IdentityUser
    {
        public float? Rating { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public virtual List<Reservation> Reservations { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
