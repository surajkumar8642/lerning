namespace StudyPlanner;

public sealed class StudySession
{
    public StudySession(string topic, int minutes)
    {
        if (string.IsNullOrWhiteSpace(topic))
        {
            throw new ArgumentException("A study topic is required.", nameof(topic));
        }

        if (minutes <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(minutes),
                "Study time must be greater than zero minutes.");
        }

        Topic = topic.Trim();
        Minutes = minutes;
    }

    public string Topic { get; }

    public int Minutes { get; }
}
