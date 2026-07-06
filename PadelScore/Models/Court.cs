namespace PadelScore.Models;
public class Court
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string PathImage { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public bool IsAvailable { get; set; }
    public DateTime? NextAvailable { get; set; }
    public decimal Price { get; set; }
    public string[] Categories { get; set; } = Array.Empty<string>();
    public string Surface { get; set; } = string.Empty;
    public string Size { get; set; } = string.Empty;
    public string Lighting { get; set; } = string.Empty;
    public string[] Amenities { get; set; } = Array.Empty<string>();
    public string ColorBackground { get; set; }
    public string ColorConfirmedGame { get; set; }
}

public class Game
{
    public int Id { get; set; }
    public string CourtName { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public string Status { get; set; } = string.Empty; // Confirmed, Past, Cancelled
    public string Result { get; set; } = string.Empty; // WIN, LOSS, null
    public int? Rating { get; set; }
    public int Capacity { get; set; }
    public int BookedCount { get; set; }
    public string Partner { get; set; } = string.Empty;
    public decimal Price { get; set; }
}

public class Pass
{
    public string Name { get; set; } = string.Empty;
    public string Emoji { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public int TotalSessions { get; set; }
    public int UsedSessions { get; set; }
    public decimal Price { get; set; }
    public decimal PerSessionPrice { get; set; }
    public string Validity { get; set; } = string.Empty;
    public string[] Features { get; set; } = Array.Empty<string>();
    public bool IsActive { get; set; }
    public bool IsBestValue { get; set; }
}

public class Ranking
{
    public int Rank { get; set; }
    public string Emoji { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int Elo { get; set; }
    public int Change { get; set; }
    public string Trend { get; set; } = string.Empty;
}