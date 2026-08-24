namespace StudyPlanner.Tests;

public sealed class StudyTrackerTests
{
    [Fact]
    public void AddSession_StoresTopicAndMinutes()
    {
        var tracker = new StudyTracker();

        var session = tracker.AddSession("  C# basics  ", 30);

        Assert.Single(tracker.Sessions);
        Assert.Equal("C# basics", session.Topic);
        Assert.Equal(30, session.Minutes);
    }

    [Fact]
    public void TotalMinutes_AddsAllSessionDurations()
    {
        var tracker = new StudyTracker();
        tracker.AddSession("System design", 30);
        tracker.AddSession("Unit testing", 25);

        Assert.Equal(55, tracker.TotalMinutes);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-10)]
    public void AddSession_RejectsNonPositiveMinutes(int minutes)
    {
        var tracker = new StudyTracker();

        Assert.Throws<ArgumentOutOfRangeException>(
            () => tracker.AddSession("Networking", minutes));
    }

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    public void AddSession_RejectsBlankTopic(string topic)
    {
        var tracker = new StudyTracker();

        Assert.Throws<ArgumentException>(() => tracker.AddSession(topic, 20));
    }
}
