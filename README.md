Skilltest
==============================

Hva er dette?
-------------

Dette er en applikasjon for å søke gjennom finn.no som bruker asp.net og ajax


Hvordan kjører du applikasjonen?
---------------

IIS Express
----------------
### Forutsetninger
For å kjøre dette programmet med ISS Express må du ha visual studio installert

[Visual Studio](https://visualstudio.microsoft.com/downloads/)

### Hvordan lager du applikasjonen?

For å lage programmet må du laste ned github prosjektet og kjøre programmet med "IIS Express"
Når du trykker på knappen, vil siden bli åpnet automatisk.

Docker
----------------
### Forutsetninger


For å kjøre dette programmet må docker være installert.

* [Windows](https://docs.docker.com/windows/started)
* [OS X](https://docs.docker.com/mac/started/)
* [Linux](https://docs.docker.com/linux/started/)

### Hvordan lager du applikasjonen?

Naviger til mappen som inneholder `docker-compose.yml` i terminalen din


Deretter skriv dette i terminalen din
```shell
docker-compose build
```

Hvis du skriver dette vil docker lage en container og starte applikasjonen automatisk.
```shell
docker-compose up
```

For å se webapplikasjonen må du besøke denne linken
http://localhost:5000/
