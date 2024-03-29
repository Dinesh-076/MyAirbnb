﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAirbnb.Models
{


    [Index(nameof(City))]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string WorkerId { get; set; }
        public virtual Worker Worker { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Title is too short (min 10)")]
        [MaxLength(100, ErrorMessage = "Title is too long (max 100)")]
        public string Title { get; set; } = "";
        [Required]
        public string Address { get; set; } = "";

        [Required]
        public string City { get; set; } = "";

        [DataType(DataType.MultilineText)]
        public string Description { get; set; } = "";

        [Display(Name = "Price per Night")]
        //[DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        [Range(1, float.MaxValue, ErrorMessage = "Invalid Price, cannot be 0")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        [Display(Name = "Number of Beds")]
        [Range(1, 50, ErrorMessage = "Invalid number of Bedrooms (1 - 50)")]
        public int NBeds { get; set; }

        [Display(Name = "Number of Bedrooms")]
        [Range(1, 50, ErrorMessage = "Invalid number of Bedrooms (1 - 50)")]
        public int NBedrooms { get; set; }

        public float Rating { get; set; }


        [Display(Name = "Space Category")]
        public int SpaceCategoryId { get; set; }
        public virtual SpaceCategory SpaceCategory { get; set; }

        public bool Hidden { get; set; } = false;

        public virtual IList<PostImage> PostImages { get; set; }
        public virtual IList<Comodity> Comodities { get; set; }
        public virtual IList<Comment> Comments { get; set; }
    }

    public class Comodity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }

    [Index(nameof(PostId))]
    public class PostImage
    {
        [Key]
        public int Id { get; set; }
        public int PostId { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public string FilePath { get; set; }
    }

    public class SpaceCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }

    [Index(nameof(ManagerId))]
    public class CheckList
    {
        [Key]
        public int Id { get; set; }
        public string ManagerId { get; set; }
        public int SpaceCategoryId { get; set; }

        public string CheckInItems { get; set; } = ""; // Separated by \n
        public string CheckOutItems { get; set; } = ""; // Separated by \n
    }


    [Index(nameof(PostId))]
    [Index(nameof(UserId))]
    [Index(nameof(WorkerId))]
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public string WorkerId { get; set; }
        //[ForeignKey(nameof(WorkerId))]
        public virtual Worker Worker { get; set; }
        //[ForeignKey(nameof(WorkerId))]

        [NotMapped]
        public virtual ApplicationUser UserWorker { get; set; }

        public int PostId { get; set; }
        public virtual Post Post { get; set; }

        public int? RatingUser { get; set; }
        public int? RatingPost { get; set; }

        public int Price { get; set; }
        [Display(Name = "Total Price")]
        public int TotalPrice { get; set; }

        public string CheckInItems { get; set; } // Separated by \n, to indicate if was checked contains '*' at the start
        public string CheckOutItems { get; set; } // Separated by \n, to indicate if was checked contains '*' at the start

        [Display(Name = "Check In Notes")]
        public string CheckInNotes { get; set; }
        [Display(Name = "Check Out Notes")]
        public string CheckOutNotes { get; set; }
        public virtual ICollection<CheckOutImage> CheckOutImages { get; set; }

        [Display(Name = "Reservation State")]
        public ReservationState State { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public virtual Comment Comment { get; set; }
    }

    [Index(nameof(ReservationId))]
    public class CheckOutImage
    {
        [Key]
        public int Id { get; set; }
        public int ReservationId { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public string FilePath { get; set; }
    }

    [Index(nameof(PostId))]
    [Index(nameof(UserId))]
    [Index(nameof(ReservationId))]
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public int PostId { get; set; }
        public virtual Post Post { get; set; }

        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Required]
        public string Text { get; set; }
    }

    public enum ReservationState { Pending, ToCheckIn, ToCheckOut, OnGoing, Accepted, Rejected, Finished } // A ordem interessa para poder ordenar as cenas na lista

    //This Ids are of the UserId of the logged user
    //The manager has multiple workers and is also a worker and all of the worker accounts created by it are also workers
    public class Manager
    {

        [Key]
        public string Id { get; set; }

        public virtual ICollection<CheckList> CheckLists { get; set; } = new List<CheckList>();
        public virtual ICollection<Worker> Workers { get; set; } = new List<Worker>();
    }

    [Index(nameof(ManagerId))]
    public class Worker
    {
        [Key]
        public string Id { get; set; }

        public string ManagerId { get; set; }
        public virtual Manager Manager { get; set; }

        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
    }

}
