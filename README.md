# Fleet Management System

<div align="center">
  <img src="https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white" alt=".NET 8.0" />
  <img src="https://img.shields.io/badge/ASP.NET_Core-MVC-blue?logo=windows&logoColor=white" alt="ASP.NET Core MVC" />
  <img src="https://img.shields.io/badge/Entity_Framework-Core-68A063?logo=nuget&logoColor=white" alt="EF Core" />
  <img src="https://img.shields.io/badge/Bootstrap-5-7952B3?logo=bootstrap&logoColor=white" alt="Bootstrap" />
</div>

## O projekcie
Kompleksowa aplikacja webowa do zarządzania flotą pojazdów, stworzona w architekturze MVC. System wspiera firmy w monitorowaniu stanu pojazdów, przypisywaniu kierowców, śledzeniu tras oraz kontroli kosztów eksploatacyjnych. 

## Spis treści
- [Główne funkcjonalności](#główne-funkcjonalności)
- [Struktura projektu](#struktura-projektu)
- [Technologie i Architektura](#technologie-i-architektura)
- [Instalacja i uruchomienie lokalnie](#instalacja-i-uruchomienie)
- [Urchomienie działającego środowiska testowego](#urchomienie-działającego-środowiska-testowego)
- [Autorzy](#autorzy)

## Główne funkcjonalności
Projekt realizuje szereg procesów biznesowych opartych na dedykowanych kontrolerach i relacyjnych modelach danych:
* **Pojazdy (`VehiclesController`):** Zarządzanie flotą, dodawanie nowych aut oraz edycja danych technicznych.
* **Kierowcy (`DriversController`):** Ewidencja personelu, kontrolowanie statusów kierowców oraz kategorii prawa jazdy.
* **Koszty i Raporty (`CostsController`, `ReportsController`):** Rejestrowanie wydatków (np. paliwo, części) i generowanie zestawień.
* **Trasy (`TripsController`):** Szczegółowe rejestrowanie przebytych tras.
* **Obsługa techniczna (`InspectionsController`, `ServicesController`, `InsuranceController`):** Nadzór nad datami przeglądów, ważnością polis ubezpieczeniowych i pełną historią napraw.
* **Administracja (`AdminController`):** Zarządzanie uprawnieniami i rolami użytkowników w systemie.

## Struktura projektu
Architektura opiera się na klasycznym wzorcu MVC, a pliki zostały zorganizowane w następujący sposób:

```text
Fleet-Managment-Production/
|-- Controllers/       # Logika biznesowa (np. TripsController.cs, CostsController.cs)
|-- Models/            # Modele danych i encje bazodanowe (np. Vehicle.cs, Driver.cs)
|-- Views/             # Interfejs użytkownika w technologii Razor (podzielony na moduły)
|-- Data/              # Kontekst bazy danych (AppDbContext.cs)
|-- Migrations/        # Historia zmian schematu bazy (Entity Framework Code-First)
|-- Services/          # Dodatkowe usługi, w tym seedowanie danych (SeedService.cs)
|-- ViewModels/        # Modele widoków służące do transferu danych (np. LoginViewModel.cs)
└-- wwwroot/           # Pliki statyczne (css, js, lib/bootstrap)
```


Ten projekt to aplikacja internetowa oparta na frameworku **ASP.NET Core 8.0**, wykorzystująca bazę danych **SQL Server** oraz **Entity Framework Core**.

## Technologie i Architektura

* **Framework:** .NET 8.0, ASP.NET Core MVC
* **Język:** C#
* **Baza danych:** SQL Server, Entity Framework Core
* **Frontend:** HTML5, CSS3, Bootstrap, JavaScript
* **Narzędzia pomocnicze:** Bogus, ASP.NET Core Identity


## Instalacja i uruchomienie

**Wymagania wstępne**

Aby uruchomić projekt, na komputerze muszą być zainstalowane następujące narzędzia:

* **.NET 8.0 SDK**: Projekt celuje w framework `net8.0`.
* **SQL Server** lub **LocalDB**: Aplikacja korzysta z `Microsoft.EntityFrameworkCore.SqlServer`.
* **Visual Studio 2022** (zalecane) lub **Visual Studio Code**.

**Konfiguracja bazy danych**

Domyślna konfiguracja wskazuje na użycie lokalnej instancji bazy danych (**LocalDB**).

1. Otwórz plik `appsettings.json`.
2. Znajdziesz tam zdefiniowany `ConnectionString` o nazwie `Default`:
   ```json
   "ConnectionStrings": {
     "Default": "Server=(localdb)\\MSSQLLocalDB;Database=Nowa_Baza;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true"
   }
   ```
3. Jeżeli używasz pełnej wersji SQL Server, zmień ten ciąg znaków na odpowiedni dla Twojej instalacji. Jeżeli uzywasz Visual Studio z domyślnymi ustawieniami, domyślna konfiguracja powinna zadziałać bez zmian.

**Automatyczne tworzenie bazy**
Kod aplikacji zawiera mechanizm SeedService, który przy starcie aplikacji automatycznie próbuje utworzyć bazę danych,
jeżeli ta nie istnieje. Nie musisz ręcznie uruchamiać migracji przy pierwszym uruchomieniu, choć jest to zalecana praktyka.

**Uruchomienie projektu**

**Visual Studio**

1. Otwórz plik rozwiązania (jeśli istnieje) lub plik projektu Fleet-Managment-Production.csproj.

2. Poczekaj, aż menedżer pakietów pobierze wymagane zależności (np. Bootstrap, EF Core).

3. Naciśnij przycisk Start (lub klawisz F5).

**Domyślne dane logowania**

Po uruchomieniu aplikacji system automatycznie utworzy konto administratora, jeśli jeszcze nie istnieje w bazie danych. Skorzystaj z poniższych danych, aby się zalogować:
 
 1. Login: admin@fleet.com
 2. Hasło: Admin@123 

Uwaga: Konto posiada przypisaną rolę Admin.

**Dodatkowe informacje**

 - Lokalizacja: Aplikajca jest skonfigurowana na polska strefę kulturową (pl-PL), co wpływa na formatowanie liczb i dat.
 - Struktura: Domyślny routing przekierowuje na kontroler Account i akcję Login

## Urchomienie działającego środowiska testowego

Otwórz stronę<br> 
https://mani3k32-001-site1.ktempurl.com

następnie zaloguj się danymi administratora

1. Login: admin@fleet.com
2. Hasło: Admin@123 

## Autorzy

**Autorzy:** 

**Patryk Mańka**

**Dominik Koźiński**

**Michał Kocik**

System rozwijany m.in. w ramach kształcenia na kierunku Informatyka, demonstrujący zastosowanie wzorców projektowych i technologii webowych w ekosystemie .NET. W ramach pracy inżynierskiej.