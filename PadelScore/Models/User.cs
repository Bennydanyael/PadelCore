namespace PadelScore.Models;

public class User
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Avatar { get; set; } = string.Empty;
    public int Elo { get; set; }
    public int GamesPlayed { get; set; }
    public int GamesWon { get; set; }
    public double WinRate => GamesPlayed > 0 ? (double)GamesWon / GamesPlayed * 100 : 0;
    public double AverageRating { get; set; }
    public UserPass Pass { get; set; } = new();
    public DateTime JoinedDate { get; set; } = DateTime.Now;
}

public class UserPass
{
    public string Name { get; set; } = "Regular Pass";
    public int TotalSessions { get; set; } = 0;
    public int UsedSessions { get; set; } = 0;
    public DateTime Expiry { get; set; } = DateTime.Now.AddDays(30);
    public bool IsActive { get; set; } = true;
    public decimal Price { get; set; } = 600000;
    public int RemainingSessions => TotalSessions - UsedSessions;
    public double Progress => TotalSessions > 0 ? (double)UsedSessions / TotalSessions : 0;
}
