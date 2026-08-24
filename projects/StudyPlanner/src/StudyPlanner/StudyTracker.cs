namespace StudyPlanner;

public sealed class StudyTracker
{
    private readonly List<StudySession> _sessions = [];

    public IReadOnlyList<StudySession> Sessions => _sessions;

    public int TotalMinutes => _sessions.Sum(session => session.Minutes);

    public StudySession AddSession(string topic, int minutes)
    {
        var session = new StudySession(topic, minutes);
        _sessions.Add(session);
        return session;
    }
}
