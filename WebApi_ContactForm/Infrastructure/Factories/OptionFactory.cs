using Infrastructure.Data.Entities;
using Infrastructure.Models;

namespace Infrastructure.Factories;

public class OptionFactory
{
    public static OptionEntity Create(OptionRegistrationForm form)
    {
        try
        {
            return new OptionEntity
            {
                Id = form.Id,
                OptionName = form.OptionName
            };

        }
        catch (Exception ex) { }
        return null!;
    }


    public static Option Create(OptionEntity entity)
    {
        try
        {
            return new Option
            {
                Id = entity.Id,
                OptionName = entity.OptionName
            };
        }
        catch (Exception ex) { }
        return null!;
    }

    public static IEnumerable<Option> Create(List<OptionEntity> entities)
    {
        var options = new List<Option>();
        try
        {
            foreach (var entity in entities)
            {
                options.Add(Create(entity));
            }
        }
        catch (Exception ex) { }
        return options!;
    }


  
    }


