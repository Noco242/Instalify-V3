using System.Collections.Generic;
namespace Instalify_V3;




    public class CategoryDataService
    {
        public List<Category> GetAllCategories()
        {
            // Beispiel-Daten für Kategorien
            return new List<Category>
            {
                new Category { Name = "Productivity", Description = "Produktivitäts-Tools für effizientes Arbeiten", Color = "#007BFF", IconClass = "bi-archive" },
                new Category { Name = "Design", Description = "Tools für Grafikdesign und kreative Gestaltung", Color = "#6610F2", IconClass = "bi-palette" },
                new Category { Name = "Media", Description = "Software für Audio- und Videobearbeitung", Color = "#28A745", IconClass = "bi-music-note" },
                new Category { Name = "Utility", Description = "Diverse Utility-Programme für verschiedene Zwecke", Color = "#DC3545", IconClass = "bi-tools" },
                new Category { Name = "Development", Description = "Entwicklungsumgebungen und Programmierwerkzeuge", Color = "#FFC107", IconClass = "bi-code-slash" },
                new Category { Name = "Communication", Description = "Kommunikationswerkzeuge und Messaging-Apps", Color = "#17A2B8", IconClass = "bi-chat" },
                new Category { Name = "Gaming", Description = "Tools und Plattformen für Spiele und Gamer", Color = "#FF5733", IconClass = "bi-folder" }
            };
        }
    }

    public class Category
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string IconClass { get; set; }
    }


