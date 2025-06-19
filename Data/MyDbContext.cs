using Microsoft.EntityFrameworkCore;
using Projet6.Models.Entities;
using OperatingSystem = Projet6.Models.Entities.OperatingSystem;
using Version = Projet6.Models.Entities.Version;

namespace Projet6.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Version> Versions { get; set; }
        public DbSet<OperatingSystem> OperatingSystems { get; set; }
        public DbSet<ProductVersionOperatingSystem> ProductVersionOperatingSystems { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Trader en Herbe" },
                new Product { ProductId = 2, Name = "Maître des Investissements" },
                new Product { ProductId = 3, Name = "Planificateur d’Entraînement" },
                new Product { ProductId = 4, Name = "Planificateur d’Anxiété Sociale" }
            );

            
            modelBuilder.Entity<OperatingSystem>().HasData(
                new OperatingSystem { OperatingSystemId = 1, Name = "Linux" },
                new OperatingSystem { OperatingSystemId = 2, Name = "MacOS" },
                new OperatingSystem { OperatingSystemId = 3, Name = "Windows" },
                new OperatingSystem { OperatingSystemId = 4, Name = "Android" },
                new OperatingSystem { OperatingSystemId = 5, Name = "iOS" },
                new OperatingSystem { OperatingSystemId = 6, Name = "Windows Mobile" }
            );

            
            modelBuilder.Entity<Version>().HasData(
              
                new Version { VersionId = 1, VersionNumber = "1.0", },
                new Version { VersionId = 2, VersionNumber = "1.1", },
                new Version { VersionId = 3, VersionNumber = "1.2", },
                new Version { VersionId = 4, VersionNumber = "1.3", },
                new Version { VersionId = 5, VersionNumber = "2.0", },
                new Version { VersionId = 6, VersionNumber = "2.1", }
         
            );

            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = 1, Name = "En cours" },
                new Status { StatusId = 2, Name = "Résolu" }
                
            );


            modelBuilder.Entity<ProductVersionOperatingSystem>().HasData(
                // Trader en Herbe 1.0
                new ProductVersionOperatingSystem { Id = 1, ProductId = 1, VersionId = 1, OperatingSystemId = 1 },
                new ProductVersionOperatingSystem { Id = 2, ProductId = 1, VersionId = 1, OperatingSystemId = 3 },

                // Trader en Herbe 1.1
                new ProductVersionOperatingSystem { Id = 3, ProductId = 1, VersionId = 2, OperatingSystemId = 1 },
                new ProductVersionOperatingSystem { Id = 4, ProductId = 1, VersionId = 2, OperatingSystemId = 2 },
                new ProductVersionOperatingSystem { Id = 5, ProductId = 1, VersionId = 2, OperatingSystemId = 3 },

                // Trader en Herbe 1.2
                new ProductVersionOperatingSystem { Id = 6, ProductId = 1, VersionId = 3, OperatingSystemId = 1 },
                new ProductVersionOperatingSystem { Id = 7, ProductId = 1, VersionId = 3, OperatingSystemId = 2 },
                new ProductVersionOperatingSystem { Id = 8, ProductId = 1, VersionId = 3, OperatingSystemId = 3 },
                new ProductVersionOperatingSystem { Id = 9, ProductId = 1, VersionId = 3, OperatingSystemId = 4 },
                new ProductVersionOperatingSystem { Id = 10, ProductId = 1, VersionId = 3, OperatingSystemId = 5 },
                new ProductVersionOperatingSystem { Id = 11, ProductId = 1, VersionId = 3, OperatingSystemId = 6 },

                // Trader en Herbe 1.3
                new ProductVersionOperatingSystem { Id = 12, ProductId = 1, VersionId = 4, OperatingSystemId = 2 },
                new ProductVersionOperatingSystem { Id = 13, ProductId = 1, VersionId = 4, OperatingSystemId = 3 },
                new ProductVersionOperatingSystem { Id = 14, ProductId = 1, VersionId = 4, OperatingSystemId = 4 },
                new ProductVersionOperatingSystem { Id = 15, ProductId = 1, VersionId = 4, OperatingSystemId = 5 },

                // Maître des Investissements 1.0
                new ProductVersionOperatingSystem { Id = 16, ProductId = 2, VersionId = 1, OperatingSystemId = 2 },
                new ProductVersionOperatingSystem { Id = 17, ProductId = 2, VersionId = 1, OperatingSystemId = 5 },

                // Maître des Investissements 2.0
                new ProductVersionOperatingSystem { Id = 18, ProductId = 2, VersionId = 5, OperatingSystemId = 2 },
                new ProductVersionOperatingSystem { Id = 19, ProductId = 2, VersionId = 5, OperatingSystemId = 4 },
                new ProductVersionOperatingSystem { Id = 20, ProductId = 2, VersionId = 5, OperatingSystemId = 5 },

                // Maître des Investissements 2.1
                new ProductVersionOperatingSystem { Id = 21, ProductId = 2, VersionId = 6, OperatingSystemId = 2 },
                new ProductVersionOperatingSystem { Id = 22, ProductId = 2, VersionId = 6, OperatingSystemId = 3 },
                new ProductVersionOperatingSystem { Id = 23, ProductId = 2, VersionId = 6, OperatingSystemId = 4 },
                new ProductVersionOperatingSystem { Id = 24, ProductId = 2, VersionId = 6, OperatingSystemId = 5 },

                // Planificateur d’Entraînement 1.0
                new ProductVersionOperatingSystem { Id = 25, ProductId = 3, VersionId = 1, OperatingSystemId = 1 },
                new ProductVersionOperatingSystem { Id = 26, ProductId = 3, VersionId = 1, OperatingSystemId = 2 },

                // Planificateur d’Entraînement 1.1
                new ProductVersionOperatingSystem { Id = 27, ProductId = 3, VersionId = 2, OperatingSystemId = 1 },
                new ProductVersionOperatingSystem { Id = 28, ProductId = 3, VersionId = 2, OperatingSystemId = 2 },
                new ProductVersionOperatingSystem { Id = 29, ProductId = 3, VersionId = 2, OperatingSystemId = 3 },
                new ProductVersionOperatingSystem { Id = 30, ProductId = 3, VersionId = 2, OperatingSystemId = 4 },
                new ProductVersionOperatingSystem { Id = 31, ProductId = 3, VersionId = 2, OperatingSystemId = 5 },
                new ProductVersionOperatingSystem { Id = 32, ProductId = 3, VersionId = 2, OperatingSystemId = 6 },

                // Planificateur d’Entraînement 2.0
                new ProductVersionOperatingSystem { Id = 33, ProductId = 3, VersionId = 5, OperatingSystemId = 2 },
                new ProductVersionOperatingSystem { Id = 34, ProductId = 3, VersionId = 5, OperatingSystemId = 3 },
                new ProductVersionOperatingSystem { Id = 35, ProductId = 3, VersionId = 5, OperatingSystemId = 4 },
                new ProductVersionOperatingSystem { Id = 36, ProductId = 3, VersionId = 5, OperatingSystemId = 5 },

                // Planificateur d’Anxiété Sociale 1.0
                new ProductVersionOperatingSystem { Id = 37, ProductId = 4, VersionId = 1, OperatingSystemId = 2 },
                new ProductVersionOperatingSystem { Id = 38, ProductId = 4, VersionId = 1, OperatingSystemId = 3 },
                new ProductVersionOperatingSystem { Id = 39, ProductId = 4, VersionId = 1, OperatingSystemId = 4 },
                new ProductVersionOperatingSystem { Id = 40, ProductId = 4, VersionId = 1, OperatingSystemId = 5 },

                // Planificateur d’Anxiété Sociale 1.1
                new ProductVersionOperatingSystem { Id = 41, ProductId = 4, VersionId = 2, OperatingSystemId = 2 },
                new ProductVersionOperatingSystem { Id = 42, ProductId = 4, VersionId = 2, OperatingSystemId = 3 },
                new ProductVersionOperatingSystem { Id = 43, ProductId = 4, VersionId = 2, OperatingSystemId = 4 },
                new ProductVersionOperatingSystem { Id = 44, ProductId = 4, VersionId = 2, OperatingSystemId = 5 }
    

            );

            modelBuilder.Entity<Ticket>().HasData(
            new Ticket
            {
                TicketId = 1,
                ProductVersionOperatingSystemId = 1,
                DateCreation = new DateTime(2023, 3,1),
                DateResolution = null,
                StatusId = 1,
                ProblemText = "Impossible de lancer l’application sur Ubuntu 20.04, message d’erreur « library not found ».",
                ResolutionText = null
            },
            new Ticket
            {
                TicketId = 2,
                ProductVersionOperatingSystemId = 9,
                DateCreation = new DateTime(2023, 4, 1),
                DateResolution = new DateTime(2023, 5, 1),
                StatusId = 2,
                ProblemText = "L’écran d’achat ne se charge pas sur certains smartphones Samsung.",
                ResolutionText = "Correction d’un bug de compatibilité avec Android 12."
            },
            new Ticket
            {
                TicketId = 3,
                ProductVersionOperatingSystemId = 13,
                DateCreation = new DateTime(2023, 5, 1),
                DateResolution = null,
                StatusId = 1,
                ProblemText = "Les notifications ne fonctionnent pas après la dernière mise à jour de Windows 11.",
                ResolutionText = null
            },
            new Ticket
            {
                TicketId = 4,
                ProductVersionOperatingSystemId = 17,
                DateCreation = new DateTime(2023, 6, 1),
                DateResolution = new DateTime(2023, 7, 1),
                StatusId = 2,
                ProblemText = "Problème d’enregistrement des données lors de la fermeture brutale de l’application.",
                ResolutionText = "Mise en place d’une sauvegarde automatique régulière."
            },
            new Ticket
            {
                TicketId = 5,
                ProductVersionOperatingSystemId = 18,
                DateCreation = new DateTime(2023, 7, 1),
                DateResolution = null,
                StatusId = 1,
                ProblemText = "Les graphiques ne s’affichent pas sur MacOS Monterey.",
                ResolutionText = null
            },
            new Ticket
            {
                TicketId = 6,
                ProductVersionOperatingSystemId = 6,
                DateCreation = new DateTime(2023, 8, 1),
                DateResolution = new DateTime(2023, 9, 1),
                StatusId = 2,
                ProblemText = "Impossible d’ajouter un nouveau portefeuille sur iPhone 14.",
                ResolutionText = "Mise à jour de l’API de gestion des portefeuilles pour corriger l’incompatibilité."
            },
            new Ticket
            {
                TicketId = 7,
                ProductVersionOperatingSystemId = 7,
                DateCreation = new DateTime(2023, 9, 1),
                DateResolution = null,
                StatusId = 1,
                ProblemText = "Le bouton « Démarrer séance » ne répond pas sur Debian 11.",
                ResolutionText = null
            },
            new Ticket
            {
                TicketId = 8,
                ProductVersionOperatingSystemId = 8,
                DateCreation = new DateTime(2023, 10, 1),
                DateResolution = null,
                StatusId = 1,
                ProblemText = "L’application plante au démarrage sur Windows 10.",
                ResolutionText = null
            },
            new Ticket
            {
                TicketId = 9,
                ProductVersionOperatingSystemId = 34,
                DateCreation = new DateTime(2023, 11, 1),
                DateResolution = null,
                StatusId = 1,
                ProblemText = "Le calendrier n’affiche plus les anciennes séances après la dernière mise à jour.",
                ResolutionText = null
            },
            new Ticket
            {
                TicketId = 10,
                ProductVersionOperatingSystemId = 39,
                DateCreation = new DateTime(2023, 12, 1),
                DateResolution = new DateTime(2024, 1, 1),
                StatusId = 2,
                ProblemText = "Problème de connexion au serveur lors du premier lancement.",
                ResolutionText = "Optimisation du processus de connexion et ajout d’un message d’attente pour l’utilisateur."
            },
            new Ticket
            {
                TicketId = 11,
                ProductVersionOperatingSystemId = 42,
                DateCreation = new DateTime(2024, 1, 1),
                DateResolution = null,
                StatusId = 1,
                ProblemText = "L’application ne se lance pas pour certains utilisateurs avec Windows 10.",
                ResolutionText = null
            },
            new Ticket
            {
                TicketId = 12,
                ProductVersionOperatingSystemId = 33,
                DateCreation = new DateTime(2024, 2, 1),
                DateResolution = new DateTime(2024, 3, 1),
                StatusId = 2,
                ProblemText = "Problème d’affichage des séances sur MacBook Air M1.",
                ResolutionText = "Ajout de la prise en charge native des processeurs Apple Silicon."
            },
            new Ticket
            {
                TicketId = 13,
                ProductVersionOperatingSystemId = 23,
                DateCreation = new DateTime(2024, 3, 1),
                DateResolution = null,
                StatusId = 1,
                ProblemText = "Les notifications push ne fonctionnent plus sur Android.",
                ResolutionText = null
            },
            new Ticket
            {
                TicketId = 14,
                ProductVersionOperatingSystemId = 5,
                DateCreation = new DateTime(2024, 4, 1),
                DateResolution = new DateTime(2024, 5, 1),
                StatusId = 2,
                ProblemText = "Impossible de sauvegarder une simulation d’achat, message « accès refusé ».",
                ResolutionText = "Mise à jour des droits d’écriture dans le dossier Documents."
            },
            new Ticket
            {
                TicketId = 15,
                ProductVersionOperatingSystemId = 30,
                DateCreation = new DateTime(2024, 5, 1),
                DateResolution = null,
                StatusId = 1,
                ProblemText = "Les rappels de séances ne s’activent pas sur certains modèles Xiaomi.",
                ResolutionText = null
            },
            new Ticket
            {
                TicketId = 16,
                ProductVersionOperatingSystemId = 41,
                DateCreation = new DateTime(2024, 6, 1),
                DateResolution = new DateTime(2024, 7, 1),
                StatusId = 2,
                ProblemText = "Fermeture inattendue de l’application lors de la consultation des statistiques hebdomadaires.",
                ResolutionText = "Correction du module d’affichage des graphiques."
            },
            new Ticket
            {
                TicketId = 17,
                ProductVersionOperatingSystemId = 10,
                DateCreation = new DateTime(2024, 7, 1),
                DateResolution = null,
                StatusId = 1,
                ProblemText = "Les achats intégrés n’aboutissent pas pour certains utilisateurs sous iOS 17.",
                ResolutionText = null
            },
            new Ticket
            {
                TicketId = 18,
                ProductVersionOperatingSystemId = 16,
                DateCreation = new DateTime(2024, 8, 1),
                DateResolution = new DateTime(2024, 9, 1),
                StatusId = 2,
                ProblemText = "Crash à l’ouverture du module d’analyse graphique.",
                ResolutionText = "Correction d’un problème de dépendance manquante sur certaines distributions MacOS."
            },
            new Ticket
            {
                TicketId = 19,
                ProductVersionOperatingSystemId = 25,
                DateCreation = new DateTime(2024, 9, 1),
                DateResolution = null,
                StatusId = 1,
                ProblemText = "Les utilisateurs ne peuvent pas importer leurs anciens programmes d’entraînement.",
                ResolutionText = null
            },
            new Ticket
            {
                TicketId = 20,
                ProductVersionOperatingSystemId = 4,
                DateCreation = new DateTime(2024, 10, 1),
                DateResolution = new DateTime(2024, 11, 1),
                StatusId = 2,
                ProblemText = "L’application se fige lors de la recherche de nouveaux titres boursiers.",
                ResolutionText = "Optimisation de la requête réseau et ajout d’un indicateur de chargement."
            },
            new Ticket
            {
                TicketId = 21,
                ProductVersionOperatingSystemId = 25,
                DateCreation = new DateTime(2024, 11, 1),
                DateResolution = null,
                StatusId = 1,
                ProblemText = "Les alertes sonores ne fonctionnent pas sous Ubuntu 22.04.",
                ResolutionText = null
            },
            new Ticket
            {
                TicketId = 22,
                ProductVersionOperatingSystemId = 22,
                DateCreation = new DateTime(2024, 12, 1),
                DateResolution = new DateTime(2025, 1, 1),
                StatusId = 2,
                ProblemText = "L’export Excel génère un fichier corrompu avec certaines versions de Microsoft Office.",
                ResolutionText = "Mise à jour du format d’export pour compatibilité avec Office 2019 et 365."
            },
            new Ticket
            {
                TicketId = 23,
                ProductVersionOperatingSystemId = 32,
                DateCreation = new DateTime(2025, 1, 1),
                DateResolution = null,
                StatusId = 1,
                ProblemText = "Les notifications ne s’affichent pas en mode économie d’énergie.",
                ResolutionText = null
            },
            new Ticket
            {
                TicketId = 24,
                ProductVersionOperatingSystemId = 6,
                DateCreation = new DateTime(2025, 2, 1),
                DateResolution = new DateTime(2025, 3, 1),
                StatusId = 2,
                ProblemText = "L’interface graphique présente des problèmes d’affichage sur certains écrans haute résolution.",
                ResolutionText = "Amélioration de la gestion du DPI dans l’application."
            },
            new Ticket
            {
                TicketId = 25,
                ProductVersionOperatingSystemId = 43,
                DateCreation = new DateTime(2025, 3, 1),
                DateResolution = null,
                StatusId = 1,
                ProblemText = "L’option de synchronisation avec Google Agenda ne fonctionne pas sur Android 13.",
                ResolutionText = null
            }

            );





            modelBuilder.Entity<ProductVersionOperatingSystem>()
                .HasKey(pvos => pvos.Id);   // Clé primaire 

            modelBuilder.Entity<ProductVersionOperatingSystem>()
                .HasOne(pvos => pvos.Product)
                .WithMany(p => p.ProductVersionOperatingSystems)
                .HasForeignKey(pvos => pvos.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductVersionOperatingSystem>()
                .HasOne(pvos => pvos.Version)
                .WithMany(v => v.ProductVersionOperatingSystems)
                .HasForeignKey(pvos => pvos.VersionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductVersionOperatingSystem>()
                .HasOne(pvos => pvos.OperatingSystem)
                .WithMany(os => os.ProductVersionOperatingSystems)
                .HasForeignKey(pvos => pvos.OperatingSystemId)
                .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(modelBuilder);
        }
    }
}
