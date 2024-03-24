using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Quic;
using SocialNetwork.Entities;

namespace SocialNetwork.Domain;

public class Birthday:ValueObject
{
    public DateOnly Date { get; }

    public Birthday(DateOnly date)
    {
        var currentDate = ToDateOnly(DateTime.Now);
        if (date > currentDate)
        {
            throw new ArgumentException("Incorrect Birthdate");
        }

        if (date.Year < currentDate.Year - 100)
        {
            throw new ArgumentException("Incorrect Birthdate");
        }
    }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Date;
    }
    
    public static DateOnly ToDateOnly(DateTime dateTime)
    {
        return new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
    }
}