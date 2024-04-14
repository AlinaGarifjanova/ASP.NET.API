
using Infrastructure.Data.Entities;
using Infrastructure.Models;
using System;

namespace Infrastructure.Factories;

public class CourseFactory
{

    public static CourseEntity Create(CourseRegistration registration)
    {
        try
        {
            var datetime = DateTime.Now;
            return new CourseEntity
            {
                Id =Guid.NewGuid().ToString(),
                Title = registration.Title,
                Author = registration.Author,
                OriginalPrice = registration.OriginalPrice,
                Hours = registration.Hours,
                IsDigital = registration.IsDigital,
                Created= datetime,
                LastUpdated= datetime,
                ImageUrl = registration.ImageUrl,
                BigImageUrl = registration.BigImageUrl,
            };
        }
        catch (Exception ex) { }
        return null!;
    }

    /*public static CourseEntity Create(SingleCourse singlecourse)
    {
        try
        {
            return new CourseEntity
            {
                Id = Guid.NewGuid().ToString(),
                Title = singlecourse.Title,
                Author = singlecourse.Author,
                OriginalPrice = singlecourse.OriginalPrice,
                Hours = singlecourse.Hours,
                IsDigital = singlecourse.IsDigital,
                IsBestseller = singlecourse.IsBestseller,
                LikesInProcent = singlecourse.LikesInProcent,
                NumberofLikes = singlecourse.NumberofLikes,
                DiscountedPrice = singlecourse.DiscountedPrice,
            };
        }catch (Exception ex) { }
        return null!;
    }*/

   /* public static SingleCourse Create(CourseEntity entity)
    {
        try{
            return new SingleCourse
            {
                Id = Guid.NewGuid().ToString(),
                Title = entity.Title,
                Author = entity.Author,
                OriginalPrice = entity.OriginalPrice,
                DiscountedPrice = entity.DiscountedPrice,
                Hours = entity.Hours,
                IsDigital = entity.IsDigital,
                IsBestseller = entity.IsBestseller,
                LikesInProcent = entity.LikesInProcent,
                NumberofLikes = entity.NumberofLikes,

            };

        }catch (Exception ex) { } 
        return null!;
    }*/


    public static Course Create(CourseEntity entity)
    {
        try
        {
            return new Course
            {
                Id = entity.Id,
                Title = entity.Title,
                Author = entity.Author,
                OriginalPrice = entity.OriginalPrice,
                DiscountedPrice = entity.DiscountedPrice,
                Hours = entity.Hours,
                IsDigital = entity.IsDigital,
                IsBestseller = entity.IsBestseller,
                NumberofLikes = entity.NumberofLikes,
                LikesInProcent = entity.LikesInProcent,
                ImageUrl =entity.ImageUrl,
                BigImageUrl = entity.BigImageUrl,
                Category = entity.Category!.CategoryName,
                
            };

        }
        catch (Exception ex) { }
        return null!;
    }


    public static CourseEntity Create(CourseRegistration registration, int categoryId)
    {
        try
        {
            var datetime = DateTime.Now;
            return new CourseEntity
            {
                Id = Guid.NewGuid().ToString(),
                Title = registration.Title,
                Author = registration.Author,
                OriginalPrice = registration.OriginalPrice,
                Hours = registration.Hours,
                IsDigital = registration.IsDigital,
                Created = datetime,
                LastUpdated = datetime,
                ImageUrl = registration.ImageUrl,
                BigImageUrl = registration.BigImageUrl,
                CategoryId = categoryId
            };
        }
        catch (Exception ex) { }
        return null!;
    }

    public static IEnumerable<Course> Create(List<CourseEntity> entities)
    {
        var courses = new List<Course>();

        try
        {
            foreach (var entity in entities)
            {
                courses.Add(Create(entity));
            }
        }
        catch (Exception ex) { }
        return courses;
    }
}
