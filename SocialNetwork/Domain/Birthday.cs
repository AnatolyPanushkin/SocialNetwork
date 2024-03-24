using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Quic;
using SocialNetwork.Entities;

namespace SocialNetwork.Domain;

public class Birthday:ValueObject
{
    public DateOnly Date { get; }

    public Birthday(DateOnly date)
    {
        if (date > ToDateOnly(DateTime.Now))
        {
            throw new ArgumentException("The date cannot be longer than the current one");
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