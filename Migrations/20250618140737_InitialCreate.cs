using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet6.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OperatingSystems",
                columns: table => new
                {
                    OperatingSystemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingSystems", x => x.OperatingSystemId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "Versions",
                columns: table => new
                {
                    VersionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versions", x => x.VersionId);
                });

            migrationBuilder.CreateTable(
                name: "ProductVersionOperatingSystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    VersionId = table.Column<int>(type: "int", nullable: false),
                    OperatingSystemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVersionOperatingSystems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVersionOperatingSystems_OperatingSystems_OperatingSystemId",
                        column: x => x.OperatingSystemId,
                        principalTable: "OperatingSystems",
                        principalColumn: "OperatingSystemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductVersionOperatingSystems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductVersionOperatingSystems_Versions_VersionId",
                        column: x => x.VersionId,
                        principalTable: "Versions",
                        principalColumn: "VersionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateResolution = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProblemText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResolutionText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductVersionOperatingSystemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_ProductVersionOperatingSystems_ProductVersionOperatingSystemId",
                        column: x => x.ProductVersionOperatingSystemId,
                        principalTable: "ProductVersionOperatingSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OperatingSystems",
                columns: new[] { "OperatingSystemId", "Name" },
                values: new object[,]
                {
                    { 1, "Linux" },
                    { 2, "MacOS" },
                    { 3, "Windows" },
                    { 4, "Android" },
                    { 5, "iOS" },
                    { 6, "Windows Mobile" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name" },
                values: new object[,]
                {
                    { 1, "Trader en Herbe" },
                    { 2, "Maître des Investissements" },
                    { 3, "Planificateur d’Entraînement" },
                    { 4, "Planificateur d’Anxiété Sociale" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "Name" },
                values: new object[,]
                {
                    { 1, "En cours" },
                    { 2, "Résolu" }
                });

            migrationBuilder.InsertData(
                table: "Versions",
                columns: new[] { "VersionId", "VersionNumber" },
                values: new object[,]
                {
                    { 1, "1.0" },
                    { 2, "1.1" },
                    { 3, "1.2" },
                    { 4, "1.3" },
                    { 5, "2.0" },
                    { 6, "2.1" }
                });

            migrationBuilder.InsertData(
                table: "ProductVersionOperatingSystems",
                columns: new[] { "Id", "OperatingSystemId", "ProductId", "VersionId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 3, 1, 1 },
                    { 3, 1, 1, 2 },
                    { 4, 2, 1, 2 },
                    { 5, 3, 1, 2 },
                    { 6, 1, 1, 3 },
                    { 7, 2, 1, 3 },
                    { 8, 3, 1, 3 },
                    { 9, 4, 1, 3 },
                    { 10, 5, 1, 3 },
                    { 11, 6, 1, 3 },
                    { 12, 2, 1, 4 },
                    { 13, 3, 1, 4 },
                    { 14, 4, 1, 4 },
                    { 15, 5, 1, 4 },
                    { 16, 2, 2, 1 },
                    { 17, 5, 2, 1 },
                    { 18, 2, 2, 5 },
                    { 19, 4, 2, 5 },
                    { 20, 5, 2, 5 },
                    { 21, 2, 2, 6 },
                    { 22, 3, 2, 6 },
                    { 23, 4, 2, 6 },
                    { 24, 5, 2, 6 },
                    { 25, 1, 3, 1 },
                    { 26, 2, 3, 1 },
                    { 27, 1, 3, 2 },
                    { 28, 2, 3, 2 },
                    { 29, 3, 3, 2 },
                    { 30, 4, 3, 2 },
                    { 31, 5, 3, 2 },
                    { 32, 6, 3, 2 },
                    { 33, 2, 3, 5 },
                    { 34, 3, 3, 5 },
                    { 35, 4, 3, 5 },
                    { 36, 5, 3, 5 },
                    { 37, 2, 4, 1 },
                    { 38, 3, 4, 1 },
                    { 39, 4, 4, 1 },
                    { 40, 5, 4, 1 },
                    { 41, 2, 4, 2 },
                    { 42, 3, 4, 2 },
                    { 43, 4, 4, 2 },
                    { 44, 5, 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "DateCreation", "DateResolution", "ProblemText", "ProductVersionOperatingSystemId", "ResolutionText", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Impossible de lancer l’application sur Ubuntu 20.04, message d’erreur « library not found ».", 1, null, 1 },
                    { 2, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "L’écran d’achat ne se charge pas sur certains smartphones Samsung.", 9, "Correction d’un bug de compatibilité avec Android 12.", 2 },
                    { 3, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Les notifications ne fonctionnent pas après la dernière mise à jour de Windows 11.", 13, null, 1 },
                    { 4, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Problème d’enregistrement des données lors de la fermeture brutale de l’application.", 17, "Mise en place d’une sauvegarde automatique régulière.", 2 },
                    { 5, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Les graphiques ne s’affichent pas sur MacOS Monterey.", 18, null, 1 },
                    { 6, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Impossible d’ajouter un nouveau portefeuille sur iPhone 14.", 6, "Mise à jour de l’API de gestion des portefeuilles pour corriger l’incompatibilité.", 2 },
                    { 7, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Le bouton « Démarrer séance » ne répond pas sur Debian 11.", 7, null, 1 },
                    { 8, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "L’application plante au démarrage sur Windows 10.", 8, null, 1 },
                    { 9, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Le calendrier n’affiche plus les anciennes séances après la dernière mise à jour.", 34, null, 1 },
                    { 10, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Problème de connexion au serveur lors du premier lancement.", 39, "Optimisation du processus de connexion et ajout d’un message d’attente pour l’utilisateur.", 2 },
                    { 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "L’application ne se lance pas pour certains utilisateurs avec Windows 10.", 42, null, 1 },
                    { 12, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Problème d’affichage des séances sur MacBook Air M1.", 33, "Ajout de la prise en charge native des processeurs Apple Silicon.", 2 },
                    { 13, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Les notifications push ne fonctionnent plus sur Android.", 23, null, 1 },
                    { 14, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Impossible de sauvegarder une simulation d’achat, message « accès refusé ».", 5, "Mise à jour des droits d’écriture dans le dossier Documents.", 2 },
                    { 15, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Les rappels de séances ne s’activent pas sur certains modèles Xiaomi.", 30, null, 1 },
                    { 16, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fermeture inattendue de l’application lors de la consultation des statistiques hebdomadaires.", 41, "Correction du module d’affichage des graphiques.", 2 },
                    { 17, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Les achats intégrés n’aboutissent pas pour certains utilisateurs sous iOS 17.", 10, null, 1 },
                    { 18, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crash à l’ouverture du module d’analyse graphique.", 16, "Correction d’un problème de dépendance manquante sur certaines distributions MacOS.", 2 },
                    { 19, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Les utilisateurs ne peuvent pas importer leurs anciens programmes d’entraînement.", 25, null, 1 },
                    { 20, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "L’application se fige lors de la recherche de nouveaux titres boursiers.", 4, "Optimisation de la requête réseau et ajout d’un indicateur de chargement.", 2 },
                    { 21, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Les alertes sonores ne fonctionnent pas sous Ubuntu 22.04.", 25, null, 1 },
                    { 22, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "L’export Excel génère un fichier corrompu avec certaines versions de Microsoft Office.", 22, "Mise à jour du format d’export pour compatibilité avec Office 2019 et 365.", 2 },
                    { 23, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Les notifications ne s’affichent pas en mode économie d’énergie.", 32, null, 1 },
                    { 24, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "L’interface graphique présente des problèmes d’affichage sur certains écrans haute résolution.", 6, "Amélioration de la gestion du DPI dans l’application.", 2 },
                    { 25, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "L’option de synchronisation avec Google Agenda ne fonctionne pas sur Android 13.", 43, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVersionOperatingSystems_OperatingSystemId",
                table: "ProductVersionOperatingSystems",
                column: "OperatingSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVersionOperatingSystems_ProductId",
                table: "ProductVersionOperatingSystems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVersionOperatingSystems_VersionId",
                table: "ProductVersionOperatingSystems",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ProductVersionOperatingSystemId",
                table: "Tickets",
                column: "ProductVersionOperatingSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StatusId",
                table: "Tickets",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "ProductVersionOperatingSystems");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "OperatingSystems");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Versions");
        }
    }
}
