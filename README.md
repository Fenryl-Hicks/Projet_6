# Projet_6

Modélisez et créez une base de données pour une application .NET

Modèle entité-association:

![MCD_Projet6 drawio](https://github.com/user-attachments/assets/081f21bf-b809-4a3e-afc3-7b843244a669)

Projet : Projet_6
Fichier : Projet_6.bak
But : Restauration de la base de données pour évaluation du projet

-----------------------------------------------
 Pré-requis pour restaurer la base :
-----------------------------------------------
- SQL Server 2019 ou plus récent (Express ou Standard)
- SQL Server Management Studio (SSMS)

-----------------------------------------------
 Informations sur la sauvegarde :
-----------------------------------------------
- Nom original de la base : Projet_6
- Fichier de sauvegarde : Projet_6.bak
- Version SQL utilisée : (localdb)\MSSQLLocalDB - SQL Server 2019 Express (v15.x)

-----------------------------------------------
 Étapes pour restaurer la base dans SSMS :
-----------------------------------------------
1. Ouvrir **SQL Server Management Studio (SSMS)**
2. Se connecter à votre serveur local (ex: `localhost\SQLEXPRESS` ou `localdb\MSSQLLocalDB`)
3. Dans l’arborescence à gauche :
   - Clic droit sur **Databases**
   - Choisir **Restore Database...**

4. Dans la fenêtre de restauration :
   - Sélectionner **Device**
   - Cliquer sur les `...` pour **ajouter le fichier `.bak`**
   - Naviguer jusqu’au fichier `Projet_6.bak` fourni avec le projet

5. Aller dans la section **Files** :
   - Cocher **Relocate all files to folder** (important pour éviter les erreurs de chemin)

6. Cliquer sur **OK** pour lancer la restauration

7. Une fois la base restaurée, elle apparaîtra dans la liste des bases.
   - Vous pouvez maintenant l'explorer ou y accéder depuis Visual Studio ou LINQPad.

