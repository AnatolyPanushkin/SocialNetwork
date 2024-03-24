using SocialNetwork.Entities;

namespace SocialNetwork.Domain;

public class Publication:ValueObject
{
    public string TextContent { get; }
    public string MediaContent { get; }

    public Publication(string textContent, string mediaContent)
    {
        TextContent = textContent?? throw new ArgumentNullException(nameof(textContent));
        MediaContent = mediaContent?? throw new ArgumentNullException(nameof(mediaContent));
    }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return TextContent;
        yield return MediaContent;
    }
}