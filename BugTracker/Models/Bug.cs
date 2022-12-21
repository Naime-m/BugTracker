﻿namespace BugTracker.Models;

public class Bug
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty; 

    public DateTime Date { get; set; }

    public Status Status { get; set; }
    public BugType BugType { get; set; }
}

public enum Status
{
    Open,
    Pending,
    Closed
}

public enum BugType
{
    Frontend,
    Backend
}