# TTDecisios

#WebService

## Description

Projet d’API Web développé en .NET 8 avec Entity Framework Core.  
Ce projet gère des utilisateurs via une architecture en plusieurs couches :  
- Domain  
- DAL (Data Access Layer)  
- BLL (Business Logic Layer)  
- API (Web API)

## Fonctionnalités principales

- CRUD complet sur les utilisateurs (Create, Read, Update, Delete)  
- Utilisation de GUID pour l’identification des utilisateurs  
- Validation des entrées avec gestion des erreurs  
- Support de SQL Server (configuration par défaut)
- Utilisation de Sqlite  

## Prérequis

- .NET 8 SDK  
- SQL Server (ou autre base selon configuration)  
- Visual Studio 2022 / VS Code / tout IDE compatible .NET  

## Installation et lancement

1. Cloner le dépôt :  
```bash
git clone https://github.com/LadyLJ13/TTDecisios.git

Configurer la chaîne de connexion dans appsettings.json
Appliquer les migrations EF (si nécessaire) :
dotnet ef database update

Lancer l’application :
dotnet run --project WebService

Accéder à l’API via Swagger :
https://localhost:<port>/swagger

Utiliser le fichier webservice.db dans Sqlite

# Dresseur_Singe

## Description

Projet C# de type console/application, partie 2 du projet TTDecisios.  
Ce projet contient la logique métier autour des entités et traitements spécifiques au module "Dresseur_Singe".

## Fonctionnalités

- Gestion des entités métier liées aux dresseurs et singes  
- Implémentation des règles métier et traitements spécifiques  
- Projet autonome pouvant être utilisé ou référencé par d’autres solutions du dépôt  

## Prérequis

- .NET 8 SDK  
- Un IDE compatible .NET (Visual Studio, VS Code, Rider...)

## Installation et exécution

1. Cloner le dépôt (si ce n’est pas déjà fait) :  
```bash
git clone https://github.com/LadyLJ13/TTDecisios.git
Naviguer dans le dossier du projet :
cd TTDecisios/Dresseur_Singe

Compiler et exécuter le projet :
dotnet run

Auteur
LadyLJ13

N’hésitez pas à me contacter pour toute question ou remarque.
