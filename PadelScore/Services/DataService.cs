using PadelScore.Models;

namespace PadelScore.Services
{

    public class DataService
    {
        public User User { get; set; } = new();
        public List<Court> CourtsPage { get; set; } = new();
        public List<Court> CourtsHome { get; set; } = new();
        public List<Game> Games { get; set; } = new();
        public List<Pass> Passes { get; set; } = new();
        public List<Models.Ranking> Rankings { get; set; } = new();

        public DataService()
        {
            InitializeData();
        }

        private void InitializeData()
        {
            // Home data
            User = new User
            {
                Name = "Alex",
                Pass = new UserPass
                {
                    Name = "Regular Pass",
                    TotalSessions = 10,
                    UsedSessions = 2,
                    Expiry = DateTime.Now.AddDays(12),
                    IsActive = true
                }
            };

            CourtsHome = new List<Court>
        {
            new()
            {
                Id = 1,
                Name = "Court A",
                Emoji = "",
                Type = "Indoor Glass",
                Color = "#ABADA6",
                Location = "Building A",
                IsAvailable = true,
                Price = 120000,
                Categories = new[] { "Indoor", "Premium" },
                Surface = "",
                Size = "20×10m",
                Lighting = "LED",
                Amenities = new[] { "AC", "Showers" }
            },
            new()
            {
                Id = 2,
                Name = "Court B",
                Emoji = "",
                Type = "Outdoor",
                Color = "#ABADA6",
                Location = "Building B",
                IsAvailable = false,
                NextAvailable = DateTime.Now.AddHours(2),
                Price = 85000,
                Categories = new[] { "Outdoor" },
                Surface = "",
                Size = "20×10m",
                Lighting = "Floodlight",
                Amenities = new[] { "Parking" }
            },
            new()
            {
                Id = 3,
                Name = "Court C",
                Emoji = "",
                Type = "Outdoor",
                Color = "#ABADA6",
                Location = "Building C",
                IsAvailable = true,
                NextAvailable = DateTime.Now.AddHours(2),
                Price = 85000,
                Categories = new[] { "Outdoor" },
                Surface = "",
                Size = "20×10m",
                Lighting = "Floodlight",
                Amenities = new[] { "Parking" }
            },            new()
            {
                Id = 4,
                Name = "Court D",
                Emoji = "",
                Type = "Glass Wall",
                Color = "#ABADA6",
                Location = "Building D",
                IsAvailable = true,
                NextAvailable = DateTime.Now.AddHours(2),
                Price = 85000,
                Categories = new[] { "Outdoor" },
                Surface = "",
                Size = "20×10m",
                Lighting = "Floodlight",
                Amenities = new[] { "Parking" }
            },
        };

            CourtsPage = new List<Court>
        {
            new()
            {
                Id = 1,
                Name = "Court A",
                Emoji = "",
                Type = "Indoor Glass",
                Color = "#ABADA6",
                Location = "Building A",
                IsAvailable = true,
                Price = 120000,
                Categories = new[] { "Indoor", "Premium" },
                Surface = "",
                Size = "20×10m",
                Lighting = "LED",
                Amenities = new[] { "AC", "Showers" },
                ColorBackground = "rgba(34, 211, 238, 0.6);"
            },
            new()
            {
                Id = 2,
                Name = "Court B",
                Emoji = "",
                Type = "Outdoor",
                Color = "#ABADA6",
                Location = "Building B",
                IsAvailable = false,
                NextAvailable = DateTime.Now.AddHours(2),
                Price = 85000,
                Categories = new[] { "Outdoor" },
                Surface = "",
                Size = "20×10m",
                Lighting = "Floodlight",
                Amenities = new[] { "Parking" }
            },
            new()
            {
                Id = 3,
                Name = "Court C",
                Emoji = "",
                Type = "Outdoor",
                Color = "#ABADA6",
                Location = "Building C",
                IsAvailable = true,
                NextAvailable = DateTime.Now.AddHours(2),
                Price = 85000,
                Categories = new[] { "Outdoor" },
                Surface = "",
                Size = "20×10m",
                Lighting = "Floodlight",
                Amenities = new[] { "Parking" }
            },            new()
            {
                Id = 4,
                Name = "Court D",
                Emoji = "",
                Type = "Glass Wall",
                Color = "#ABADA6",
                Location = "Building D",
                IsAvailable = true,
                NextAvailable = DateTime.Now.AddHours(2),
                Price = 85000,
                Categories = new[] { "Outdoor" },
                Surface = "",
                Size = "20×10m",
                Lighting = "Floodlight",
                Amenities = new[] { "Parking" }
            },
        };

            // Games data
            Games = new List<Game>
        {
            new()
            {
                Id = 1,
                CourtName = "Padel Arena",
                Date = DateTime.Now.AddDays(1),
                Time = new TimeSpan(15, 0, 0),
                Status = "Confirmed",
                Capacity = 4,
                BookedCount = 3,
                Partner = "Rahmat",
                Price = 120000
            },
            // Add more games...
        };

            // Passes data
            Passes = new List<Pass>
        {
            new()
            {
                Name = "Starter",
                Emoji = "🚀",
                Color = "#A3E635",
                TotalSessions = 5,
                Price = 350000,
                PerSessionPrice = 70000,
                Validity = "30 days",
                Features = new[] { "Basic court access", "Equipment rental" },
                IsBestValue = false
            },
            new()
            {
                Name = "Regular",
                Emoji = "⭐",
                Color = "#22D3EE",
                TotalSessions = 10,
                Price = 600000,
                PerSessionPrice = 60000,
                Validity = "60 days",
                Features = new[] { "Priority booking", "Equipment rental", "Free water" },
                IsBestValue = true
            },
            new()
            {
                Name = "Elite",
                Emoji = "👑",
                Color = "#F59E0B",
                TotalSessions = 20,
                Price = 1000000,
                PerSessionPrice = 50000,
                Validity = "90 days",
                Features = new[] { "VIP lounge access", "Free coaching", "Premium equipment", "Guest passes" },
                IsBestValue = false
            }
        };

            // Rankings data
            Rankings = new List<Models.Ranking>
            {
                new() { Rank = 1, Emoji = "🥇", Name = "Alex", Elo = 1842, Change = 12, Trend = "up" },
                new() { Rank = 2, Emoji = "🥈", Name = "Budi", Elo = 1791, Change = -5, Trend = "down" },
                new() { Rank = 3, Emoji = "🥉", Name = "Charlie", Elo = 1754, Change = 3, Trend = "up" },
                new() { Rank = 4, Emoji = "", Name = "Dewi", Elo = 1720, Change = 0, Trend = "same" },
                new() { Rank = 5, Emoji = "", Name = "Eko", Elo = 1698, Change = -8, Trend = "down" }
            };
        }
    }
}
