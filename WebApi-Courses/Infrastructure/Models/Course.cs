﻿using Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models;

public class Course
{
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string OriginalPrice { get; set; } = null!;
    public string? DiscountedPrice { get; set; }
    public int Hours { get; set; }
    public string? LikesInProcent { get; set; }
    public string? NumberofLikes { get; set; }
    public bool IsDigital { get; set; }
    public bool IsBestseller { get; set; }
    public string? ImageUrl { get; set; }
    public string? BigImageUrl { get; set; }

    public string Category { get; set; } = null!;
}
