<img src="https://github.com/Digital-Architects-Avans/dotnetflix/blob/main/dotnetflix.Web/wwwroot/images/dotnetflix-logo-white.svg" alt="dotnetflix logo" width="300"/>


.NETflix is een uitgebreide applicatie voor het boeken van bioscoopkaartjes, gebouwd op de ASP.NET Core Web API en Blazor WebAssembly (WASM) technologieën. De applicatie biedt verschillende functies voor gebruikers om films te verkennen, kaartjes te boeken en te genieten van een geweldige bioscoopervaring.

## Inhoudsopgave

1. [Overzicht](https://github.com/Digital-Architects-Avans/dotnetflix/edit/main/README.md#overzicht)
2. [Backend (ASP.NET Core Web API - dotnetfix.Api)](https://github.com/Digital-Architects-Avans/dotnetflix/edit/main/README.md#backend-aspnet-core-web-api---dotnetfixapi)
3. [Frontend (Blazor WASM Web App - dotnetflix.Web)](https://github.com/Digital-Architects-Avans/dotnetflix/edit/main/README.md#frontend-blazor-wasm-web-app---dotnetflixweb)
4. [Aanvullende functies](https://github.com/Digital-Architects-Avans/dotnetflix/edit/main/README.md#aanvullende-functies)
5. [Aan de slag](https://github.com/Digital-Architects-Avans/dotnetflix/edit/main/README.md#aan-de-slag)
6. [Licentie](https://github.com/Digital-Architects-Avans/dotnetflix/edit/main/README.md#licentie)


## Overzicht

Het project bestaat uit drie solutions:

1. **dotnetfix.Api**: ASP.NET Core Web API welke fungeert als de backend voor de applicatie. De API handelt CRUD-operaties af voor verschillende entiteiten en beheert interacties met de database.
2. **dotnetflix.Web**: Blazor WASM Web App welke fungeert als de frontend voor de applicatie. Deze biedt een gebruiksvriendelijke interface voor gebruikers om te communiceren met de services die worden aangeboden door de backend.
3. **dotnetflix.Models**: Classlibrary met Data Transfer Objects (DTO's) welke worden gebruikt om gegevens tussen de API en de client over te dragen.

## Backend (ASP.NET Core Web API - `dotnetfix.Api`)

### Functies

- **Controllers en Repositories**: Handel CRUD-operaties af voor entiteiten zoals films, theaters, shows, tickets, etc.
- **Entity Framework Core en Azure SQL Database**: Gebruikt voor gegevenstoegang en opslag, zorgt voor schaalbaarheid, betrouwbaarheid en beveiliging.
- **Authenticatie en Autorisatie**: Geïmplementeerd met behulp van Auth0, waardoor gebruikers zich kunnen authenticeren via sociale referenties en op rollen gebaseerde autorisatie voor veilige toegang.

## Frontend (Blazor WASM Web App - `dotnetflix.Web`)

### Functies

- **Razor-onderdelen en -pagina's**: Verbeteren de code modulariteit en onderhoudbaarheid, bieden herbruikbare UI-elementen en individuele pagina's.
- **UI-logica en interactie**: Intuïtieve UI-componenten begeleiden gebruikers door het proces van het boeken van kaartjes, met ondersteuning voor navigatie in meerdere talen en integratie met Google Maps.
- **PayPal-integratie**: Integratie met PayPal voor veilige betalingsverwerking, biedt verschillende betaalmethoden tijdens het afrekenen, zoals creditcard, Ideal of PayPal.
- **Manager Dashboard**: Een dashboard voor managers om administratieve taken uit te voeren zoals het toevoegen van films, theaters, shows en het maken van nieuwsbrieven.

## Aanvullende functies

- **Manager Systeem**: Stelt managers in staat om films, theaters en shows toe te voegen aan de applicatie.
- **Overzichts- en Agenda-pagina's**: Bieden gebruikers een overzicht van shows die draaien in theaters en een wekelijks agendaoverzicht.
- **Filmdetails Component**: Maakt het mogelijk voor gebruikers om gedetailleerde informatie over films te bekijken voordat ze kaartjes selecteren.
- **Volledig Kaartjesbestelproces**: Stelt gebruikers in staat om shows, voorkeursstoelen en arrangementen te selecteren tijdens het afrekenen.
- **Gedisconteerde Ticketopties**: Ondersteunt verschillende tickettypes met kortingen, waaronder studenten-, senioren-, kinder- en VIP-tickets.
- **PDF Ticket Afdrukken**: Gebruikers kunnen PDF-tickets afdrukken voor hun geboekte shows.
- **Sneak Preview Film**: Biedt gedisconteerde tickets voor onbekende films.
- **Zoekfunctionaliteit**: Maakt het mogelijk voor gebruikers om te zoeken naar films binnen de applicatie.
- **Nieuwsbriefabonnement**: Stelt gebruikers in staat om zich aan te melden voor nieuwsbrieven en managers om nieuwsbrieven te maken en te verzenden.
- **Beoordelingssysteem**: Maakt het mogelijk voor gebruikers om beoordelingen achter te laten over hun bioscoopervaring.

## Aan de slag

Om de .NETflix applicatie lokaal uit te voeren, volg deze stappen:

1. Kloon deze repository naar uw lokale machine.
2. Navigeer naar de afzonderlijke `dotnetfix.Api` en `dotnetflix.Web` directories en voer `dotnet run` uit om de backend API en de frontend Blazor-app te starten.
3. Zorg ervoor dat u de nodige afhankelijkheden en configuraties heeft ingesteld, inclusief toegang voor de database en Auth0-inloggegevens.

## Licentie

Dit project is gelicentieerd onder de [MIT-licentie](LICENSE).
