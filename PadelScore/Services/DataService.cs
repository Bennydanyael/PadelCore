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
                Type = "Indoor Glass",
                Color = "rgba(34, 211, 238, 0.5);",
                Location = "Building A",
                IsAvailable = true,
                Price = 120000,
                Categories = new[] { "Indoor", "Premium" },
                Surface = "",
                Size = "20×10m",
                Lighting = "LED",
                Amenities = new[] { "AC", "Showers" },
                PathImage = "Images/CourtsA.png",
                ColorBackground = "rgba(34, 211, 238, 0.5);",
                ColorConfirmedGame = "rgba(34, 197, 94, 0.5);"
            },
            new()
            {
                Id = 2,
                Name = "Court B",
                Type = "Outdoor",
                Color = "rgba(180, 130, 60, 0.5);",
                Location = "Building B",
                IsAvailable = false,
                NextAvailable = DateTime.Now.AddHours(2),
                Price = 85000,
                Categories = new[] { "Outdoor" },
                Surface = "",
                Size = "20×10m",
                Lighting = "Floodlight",
                Amenities = new[] { "Parking" },
                PathImage = "Images/CourtsB.png",
                ColorConfirmedGame = "rgba(34, 197, 94, 0.5);"
            },
            new()
            {
                Id = 3,
                Name = "Court C",
                Type = "Outdoor",
                Color = "rgba(180, 130, 60, 0.5);",
                Location = "Building C",
                IsAvailable = true,
                NextAvailable = DateTime.Now.AddHours(2),
                Price = 85000,
                Categories = new[] { "Outdoor" },
                Surface = "",
                Size = "20×10m",
                Lighting = "Floodlight",
                PathImage = "Images/CourtsC.png",
                Amenities = new[] { "Parking" },
                ColorConfirmedGame = "rgba(34, 197, 94, 0.5);"
            },            new()
            {
                Id = 4,
                Name = "Court D",
                Type = "Glass Wall",
                Color = "rgba(139, 92, 246, 0.5)",
                Location = "Building D",
                IsAvailable = true,
                NextAvailable = DateTime.Now.AddHours(2),
                Price = 85000,
                Categories = new[] { "Outdoor" },
                Surface = "",
                Size = "20×10m",
                Lighting = "Floodlight",
                PathImage = "Images/CourtsD.png",
                Amenities = new[] { "Parking" },
                ColorBackground = "rgba(139, 92, 246, 0.5);"
            },
        };

            CourtsPage = new List<Court>
        {
            new()
            {
                Id = 1,
                Name = "Court A",
                PathImage = "Images/CourtsA.png",
                Type = "Indoor Glass",
                Color = "rgba(34, 211, 238, 0.5);",
                Location = "Kemang, Jaksel",
                IsAvailable = true,
                Price = 200000,
                Categories = new[] { "Indoor", "Premium" },
                Surface = "Artificial Turf",
                Size = "10 × 20 m",
                Lighting = "LED 400 LUX",
                Amenities = new[] { "AC", "Showers" },
                ColorBackground = "rgba(34, 211, 238, 0.5);",
                NextAvailable = DateTime.Now.AddHours(3).AddMinutes(0),
                ColorConfirmedGame = "rgba(34, 197, 94, 0.5);",
                Time = new TimeSpan(19, 0, 0)
            },
            new()
            {
                Id = 2,
                Name = "Court B",
                PathImage = "Images/CourtsB.png",
                Type = "Outdoor",
                Color = "rgba(163, 230, 53, 0.5)",
                Location = "PIK, Jakarta Utara",
                IsAvailable = false,
                NextAvailable = DateTime.Now.AddHours(3).AddMinutes(0),
                Price = 150000,
                Categories = new[] { "Outdoor" },
                Surface = "Sand & Turf",
                Size = "10 × 20 m",
                Lighting = "Halogen 350 lux",
                Amenities = new[] { "Parking" },
                ColorBackground = "rgba(163, 230, 53, 0.5);",
                ColorConfirmedGame = "rgba(163, 230, 53, 0.5);",
                Time = new TimeSpan(09, 0, 0)
            },
            new()
            {
                Id = 3,
                Name = "Court C",
                PathImage = "Images/CourtsC.png",
                Type = "Outdoor",
                Color = "rgba(180, 130, 60, 0.5);",
                Location = "Alam Sutera, Tangerang",
                IsAvailable = true,
                NextAvailable = DateTime.Now.AddHours(3).AddMinutes(0),
                Price = 350000,
                Categories = new[] { "Outdoor" },
                Surface = "Pro Artificial Turf",
                Size = "10 × 20 m",
                Lighting = "Tournament 600 lux",
                Amenities = new[] { "Parking" },
                ColorBackground = "rgba(180, 130, 60, 0.5);",
                Time = new TimeSpan(09, 0, 0)
            },            new()
            {
                Id = 4,
                Name = "Court D",
                PathImage = "Images/CourtsD.png",
                Type = "Glass Wall",
                Color = "rgba(139, 92, 246, 0.5)",
                Location = "Kemang, Jaksel",
                IsAvailable = true,
                NextAvailable = DateTime.Now.AddHours(3).AddMinutes(0),
                Price = 280000,
                Categories = new[] { "Outdoor" },
                Surface = "Artificial Turf",
                Size = "10 × 20 m",
                Lighting = "LED 500 lux",
                Amenities = new[] { "Parking" },
                ColorBackground = "rgba(139, 92, 246, 0.5)"
            },
        };

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
        };

            Games.AddRange(new List<Game>
            {
                new()
                {
                    Id = 1,
                    CourtName = "Court A",
                    Date = new DateTime(2026, 6, 1),
                    Time = new TimeSpan(18, 0, 0),
                    Status = "Past",
                    Result = "WIN",
                    Opponent = "Budi & Andi",
                    Score = "6–3, 6–4",
                    Rating = null,
                    PathImage = "Images/CourtsA.png"
                },
                new()
                {
                    Id = 2,
                    CourtName = "Court B",
                    Date = new DateTime(2026, 5, 28),
                    Time = new TimeSpan(16, 0, 0),
                    Status = "Past",
                    Result = "LOSS",
                    Opponent = "Hendra",
                    Score = "3–6, 4–6",
                    Rating = 4,
                    PathImage = "Images/CourtsB.png",
                },
                new()
                {
                    Id = 3,
                    CourtName = "Court C",
                    Date = new DateTime(2026, 5, 24),
                    Time = new TimeSpan(9, 0, 0),
                    Status = "Past",
                    Result = "WIN",
                    Opponent = "Sinta & Budi",
                    Score = "6–2, 6–1",
                    Rating = 5,
                    PathImage = "Images/CourtsC.png",
                }
            });

            Passes = new List<Pass>
        {
            new()
            {
                Name = "Starter",
                Emoji = "🚀",
                Color = "rgb(163, 230, 53)",
                TotalSessions = 5,
                Price = 600000,
                PerSessionPrice = "120k",
                Validity = "3 bulan",
                Features = new[] { "5 court sessions", "All court types", "Valid 3 months", "App booking" },
                IsBestValue = false,
                ImagePath = "Images/Passes.png"
            },
            new()
            {
                Name = "Regular",
                Emoji = "⭐",
                Color = "rgb(34, 211, 238)",
                TotalSessions = 10,
                Price = 1100000,
                PerSessionPrice = "110k",
                Validity = "6 bulan",
                Features = new[] { "10 court sessions", "All court types", "Valid 6 month", "Priority booking" },
                IsBestValue = true,
                ImagePath = "Images/CourtsA.png"
            },
            new()
            {
                Name = "Premium",
                Emoji = "👑",
                Color = "rgb(245, 158, 11)",
                TotalSessions = 20,
                Price = 2100000,
                PerSessionPrice = "210k",
                Validity = "9 bulan",
                Features = new[] { "15 court sessions", "All court types", "Valid 9 month", "Premium booking" },
                IsBestValue = false,
                ImagePath = "Images/CourtsB.png"
            }
        };

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
