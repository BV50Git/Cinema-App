﻿using CInemaApp;
using System;
using System.Security.Cryptography.X509Certificates;


class Translation
{
    public static string SR1 = "Enter the row of the seat you want to reserve";
    public static string SR2 = "Enter the column of the seat you want to reserve";
    public static string SR3 = "Unavailible seat, try again.";
    public static string SR4 = "Type OK to confirm reservation, type anything else to select another seat.";
    public static string SR5 = "IDEAL (option 1)";
    public static string SR6 = "Credit Card (option 2)";
    public static string SR7 = "Please enter your IDEAL information";
    public static string SR8 = "Please enter your Credit Card information";
    public static string SR9 = "Payment completed";
    public static string SR10 = "The price for";
    public static string SR11 = "At what time does the movie play?";
    public static string SR12 = "At which date does the movie play?";
    public static string SR13 = "Please enter the password: ";
    public static string SR14 = "Wrong input. Please try again";
    public static string SR15 = "Are you an Admin or User? [A/U]";
    public static string SR16 = "To go back to the main menu, please press Enter.";
    public static string SR17 = "Phone number: 06123456789";
    public static string SR18 = "Email: cinemapp@hr.nl\n";
    public static string SR19 = "Welcome to the current movies page!";
    public static string SR20 = "Please press 1 to go ot the information page\nPress 2 to exit ";
    public static string SR21 = "input invalid please try again";
    public static string SR22 = "Friday - 'Horror Movie Night!'\n     All horror movies will be available to watch for 50% off " +
                    "during this event!";
    public static string SR23 = "Saturday - 'Family Day!'\n     Each family that arrives at our cinema gets a " +
                    "free ticket to spend on food and beverages as they like!";
    public static string SR24 = "Sunday - 'Premiere Night!'\n     On this day, one or more movies from the " +
                    "'Upcoming Movies' list will be shown for the first time in our cinema! Don't miss it!";
    public static string SR25 = "Welcome to the upcoming movies page!";
    public static string SR26 = "Welcome to the events page!";
    public static string SR27 = "Welcome to Sally's Café!";
    public static string SR28 = "Goodbye";
    public static string SR29 = "False input. Try again.";
    public static string SR30 = "[1] - Current Movies";
    public static string SR31 = "[2] - Upcoming Movies";
    public static string SR32 = "[3] - Movie Prices";
    public static string SR33 = "[4] - Events";
    public static string SR34 = "[5] - Sally's Café";
    public static string SR35 = "[6] - Contact information";
    public static string SR36 = "[7] - Subscriptions";
    public static string SR37 = "Please choose an option to continue.";
    public static string SR38 = "These are the upcoming Movies: ";
    public static string SR39 = "Please type your choice 1 to fill in information. 2 to write the new information to the json file\n 3 to get information from the json file. 4 to exit";
    public static string SR40 =  "What can I help you with today?";
    public static string SR41 = "1) Display Food & Drink menu";
    public static string SR42 = "2) Display payment options";
    public static string SR43 = "3) Order from Food & Drink menu";
    public static string SR44 = "4) Exit\n";
    public static string SR45 = "Please select your option";
    public static string SR46 = "These are the payment options\n";
    public static string SR47 = "1) IDEAL";
    public static string SR48 = "2) Credit Card";
    public static string SR49 = "Your choice is: ";
    public static string SR50 = "You have succesfully ordered ";
    public static string SR51 = "We don't seem to have that item. Please try again.";
    public static string SR52 = "Thank you for visiting Sally's Café";
    public static string SR53 = "Enter your selection please: \n";
    public static string SR54 = "Movie not found";
    public static string SR55 = "Below age 12";
    public static string SR56 = "Age 12 to 26";
    public static string SR57 = "Age 27 to 50";
    public static string SR58 = "The prices are as follows: ";
    public static string SR59 = "Please choose your age group";
    public static string SR60 = "Press 1 if you are below 12 years old\nPress 2 if you are between 12 and 26 years old\nPress 3 if you are between 27 and 50 years old\nPress 4 if you are 50 years or older";
    public static string SR61 = "This group member ";
    public static string SR62 = "and is below 12 years old. ";
    public static string SR63 = "and is between 12 and 26 years old. ";
    public static string SR64 = "and is between 27 and 50 years old. ";
    public static string SR65 = "and is 50 years or older. ";
    public static string SR66 = "You are ";
    public static string SR67 = "and you are below 12 years old. ";
    public static string SR68 = "and you are between 12 and 26 years old. ";
    public static string SR69 = "and you are between 27 and 50 years old. ";
    public static string SR70 = "and you are 50 years or older. ";
    public static string SR71 = "We want to ask you to pay for the reservation of the movie: ";
    public static string SR72 = "We are calculating your Bill";
    public static string SR73 = "Please choose a payment option";
    public static string SR74 = "Please enter your IDEAL information, 8 digit code\n *********************";
    public static string SR75 = "Please try again, you seemed to have typed the wrong code";
    public static string SR76 = "Please enter your Credit Card information, 8 digit code\n *********************";
    public static string SR77 = "Everything has been payed for";
    public static string SR78 = "Enter the name of the movie you want to make a reservation for: ";
    public static string SR79 = "Reservation for ";
    public static string SR80 = "made. Your seats are: ";
    public static string SR81 = "The prices are as follows:";
    public static string SR82 = "For our COVID-19 Regulations please press 'C'\nFor our regularly scheduled events press 'E'";
    public static string SR83 = "Due to the current circumstances and the social distancing order, Cinemapps has unfortunately had to" +
                    " close their doors for a short while.";
    public static string SR84 = "However, since reopening we have been trying our hardest to get back to how things used to be," +
                    " with some added changes to uphold the new rules.\n\nAs such, we've had to remove some of our previous events" +
                    " and swap them out in favor of new ones that don't put a lot of people at risk. ";
    public static string SR85 = "We are sorry for the inconvenience and hope for your understanding.";
    public static string SR86 = "Press any key to go back to the Events page";
    public static string SR87 = "Current ongoing events:";
    public static string SR88 = "Welcome to the subscriptions page!";
    public static string SR89 = "Press 'S' to subscribe,\n'I' for more information,\n'Enter' to go back to the main menu";
    public static string SR90 = "Thank you for choosing to subscribe to the Cinemapps newsletter! Please enter the following information:";
    public static string SR91 = "First name: ";
    public static string SR92 = "Surname: ";
    public static string SR93 = "Age: ";
    public static string SR94 = "Email: ";
    public static string SR95 = "Press any key to go back to the subscription page";
    public static string SR96 = "If you subscribe to Cinemapps, you will receive a monthly news letter by email!";
    public static string SR97 = "It will include information about upcoming movies, events, and eventual discounts, as well as any other news surrounding our beloved cinema!";
    public static string SR98 = "Welcome to Sally's! Prices are in $$$";
    public static string SR99 = "Tea";
    public static string SR100 = "Coffee";
    public static string SR101 = "Soda";
    public static string SR102 = "Beer";
    public static string SR103 = "Wine";
    public static string SR104 = "Small Popcorn";
    public static string SR105 = "Medium Popcorn";
    public static string SR106 = "Big Popcorn";
    public static string SR107 = "Cotton Candy";
    public static string SR108 = "Big Cotton Candy";
    public static string SR109 = "Small Ben & Jerry's";
    public static string SR110 = "Big Ben & Jerry's";
    public static string SR111 = "Dunkin Donuts set of 3";
    public static string SR112 = "Dunkin Donuts set of 6";
    public static string SR113 = "Press any key to order";
    public static string SR114 = "Please choose your payment option";
    public static string SR115 = "What would you like to order? Remember to use Capital Letters!!!\n";
    public static string SR116 = "You will have to pay $";
    public static string SR117 = "!";
    public static string SR118 = "To go back to the main menu, please press Enter";
    public static string SR119 = "These are the current subscribers:\n";
    public static string SR120 = "Name of the movie: ";
    public static string SR121 = "A movie with that name already exists";
    public static string SR122 = "Movie description: ";
    public static string SR123 = "Movie length (minutes): ";
    public static string SR124 = "Movie genre: ";
    public static string SR125 = "Enter the name of the movie you want to remove: ";
    public static string SR126 = "[8] - Language";
    public static string SR127 = "[4] - Sally's Café";
    public static string SR128 = "[5] - Contact Information";
    public static string SR129 = "[6] - Add Movie";
    public static string SR130 = "[7] - Remove Movie";
    public static string SR131 = "[8] - Subscriptions";
    public static string SR132 = "[9] - Quit";
    public static string SR133 = "is";
    public static string SR134 = "Enter Nederlands to switch language to Dutch (Nederlands)\nEnter anything else to keep English as the language\n";
    public static string SR135 = "[9] - Language";
    public static string SR136 = "[10] - Quit";
    public static string SR137 = "50+";
    public static void dutch()
    {
        Console.WriteLine(SR134);
        string languageSwitch = Console.ReadLine();
        if (languageSwitch == "Nederlands")
        {
            SR1 = "Voer de rij in van de zitplaats die u wilt reserveren";
            SR2 = "Voer het kolom in van de zitplaats die u wilt reserveren";
            SR3 = "Onbeschikbare zitplaats, probeer opnieuw.";
            SR4 = "Typ OK om uw reservatie te bevestigen, typ iets anders om nog een zitplaats te selecteren.";
            SR5 = "IDEAL (optie 1)";
            SR6 = "Credit Card (optie 2)";
            SR7 = "Voer alstublieft uw IDEAL gegevens in";
            SR8 = "Voer alstublieft uw Credit Card gegevens in";
            SR9 = "Betaling geslaagd";
            SR10 = "De prijs voor";
            SR11 = "Hoelaat draait de film?";
            SR12 = "Op welke datum draait de film?";
            SR13 = "Voer alstublieft het wachtwoord in: ";
            SR14 = "Verkeerde input. Probeer opnieuw alstublieft";
            SR15 = "Bent u een Admin of een Gebruiker? [A/U]";
            SR16 = "Om terug te gaan naar het hoofdmenu, druk alstublieft op Enter.";
            SR17 = "Telefoon nummer: 06123456789";
            SR18 = "Email: cinemapp@hr.nl\n";
            SR19 = "Welkom op de huidige films pagina!";
            SR20 = "Druk op 1 om naar de informatiepagina te gaan\nDruk op 2 om af te sluiten ";
            SR21 = "Verkeerde input, probeer opnieuw alstublieft";
            SR22 = "Vrijdag - 'Horrorfilms avond!'\n    Alle Horrorfilms zullen beschikbaar zijn om te kijken met 50% korting tijdens dit evenement!";
            SR23 = "Zaterdag - 'Familie dag!'\n     Elke familie die bezoekt krijgt een gratis kaartje die kan worden gespendeerd op eten en drankjes!";
            SR24 = "Zondag - 'Première Avond!'\n    Op deze dag wordt één of meer van de 'Toekomende Films' lijst voor de eerste keer in onze bioscoop gedraait. Mis dit niet!";
            SR25 = "Welkom bij de toekomende films pagina!";
            SR26 = "Welkom bij de evenementenpagina!";
            SR27 = "Welkom bij Sally's Café!";
            SR28 = "Tot ziens";
            SR29 = "Verkeerde input, probeer alstublieft opnieuw";
            SR30 = "[1] - Huidige Films";
            SR31 = "[2] - Toekomende Films";
            SR32 = "[3] - Film Prijzen";
            SR33 = "[4] - Evenementen";
            SR34 = "[5] - Sally's Café";
            SR35 = "[6] - Contact Informatie";
            SR36 = "[7] - Abbonomenten";
            SR37 = "Kies een optie om verder te gaan";
            SR38 = "Dit zijn de toekomende films: ";
            SR39 = "Kies keuze 1 om informatie in te vullen. Kies keuze 2 om de nieuwe informatie naar het json bestand te schrijven.\n Kies keuze 3 om informatie van het json bestand te krijgen. Kies keuze 4 om af te sluiten";
            SR40 = "Waar kan ik u vandaag mee helpen?";
            SR41 = "1) Laat het Eten & Drinken menu zien";
            SR42 = "2) Laat de betaal opties zien";
            SR43 = "3) Bestel van het Eten & Drinken menu";
            SR44 = "4) Afsluiten\n";
            SR45 = "Selecteer uw optie";
            SR46 = "Dit zijn de betaal opties\n";
            SR47 = "1) IDEAL";
            SR48 = "2) Creditcard";
            SR49 = "Uw keuze is: ";
            SR50 = "U heeft besteld: ";
            SR51 = "Wij hebben uw gekozen product niet. Probeer opnieuw.";
            SR52 = "Bedankt voor uw bezoek aan Sally's Café";
            SR53 = "Voer uw selectie in: \n";
            SR54 = "Film niet gevonden";
            SR55 = "Jonger dan 12 jaar.";
            SR56 = "Leeftijd tussen 12 en 26 jaar.";
            SR57 = "Leeftijd tussen 27 en 50 jaar.";
            SR58 = "De prijzen zijn als volgt";
            SR59 = "Kies uw leeftijdsgroep alstublieft";
            SR60 = "Druk op 1 als u onder de 12 jaar bent\nDruk op 2 als u tussen de 12 en 26 jaar bent\nDruk op 3 als u tussen de 27 en 50 jaar bent\nDruk op 4 als u 50 jaar of ouder bent";
            SR61 = "Dit groepslid ";
            SR62 = "en is jonger dan 12 jaar oud. ";
            SR63 = "en is tussen de 12 en 26 jaar oud. ";
            SR64 = "en is tussen de 27 en 50 jaar oud. ";
            SR65 = "en is 50 jaar of ouder. ";
            SR66 = "U bent ";
            SR67 = "en u bent jonger dan 12 jaar oud. ";
            SR68 = "en u bent tussen de 12 en 26 jaar oud. ";
            SR69 = "en u bent tussen de 27 en 50 jaar oud. ";
            SR70 = "en u bent 50 jaar of ouder. ";
            SR71 = "Wij vragen u; om te betalen voor de film reservering: ";
            SR72 = "Wij zijn uw rekening aan het berekenen";
            SR73 = "Kies alstublieft een betaal optie";
            SR74 = "Voer alstublieft uw IDEAL informatie in, 8 cijfer code\n *********************";
            SR75 = "Probeer alstublieft opnieuw, u heeft de verkeerde code ingetypt";
            SR76 = "Voer alstublieft uw Credit Card informatie in, 8 cijfer code\n *********************";
            SR77 = "Alles is betaald";
            SR78 = "Voer de naam in van de film waar u een reservering voor wilt maken: ";
            SR79 = "Reservering voor: ";
            SR80 = "gemaakt. Uw stoelen zijn: ";
            SR81 = "De prijzen zijn als volgt";
            SR82 = "Voor onze COVID-19 regelgeving, druk op 'C'\nVoor onze normaal geplande evenementen, druk op 'E'";
            SR83 = "Door de huidige toestand en de Social Distancing regels heeft Cinemapps helaas moeten sluiten voor een korte tijd.";
            SR84 = "Sinds de heropening doen wij onze best om alles weer terug te brengen naar hoe het was, met wat toegevoegde veranderingen om de regels te volgen.\n\nHierom hebben wij wat van onze eerdere evenementen moeten weghalen en vervangen met nieuwe evenementen die geen risico veroorzaken voor de bezoekers.";
            SR85 = "Het spijt ons voor het ongemak en hopen voor uw begrip";
            SR86 = "Druk op een toets om terug te gaan naar de Evenementen pagina";
            SR87 = "Huidige Evenementen";
            SR88 = "Welkom bij de abbonomenten pagina!";
            SR89 = "Druk op 'S' om te abboneren,\ndruk op 'I' voor meer informatie,\nDruk op 'Enter' om terug te gaan naar het hoofdmenu";
            SR90 = "Bedankt voor het abboneren op de Cinemapps nieuwsbrief! Voer alstublieft de volgende informatie in:";
            SR91 = "Voornaam: ";
            SR92 = "Achternaam: ";
            SR93 = "Leeftijd: ";
            SR94 = "Email: ";
            SR95 = "Druk op een toets om terug te gaan naar de abbonomenten pagina";
            SR96 = "Als u abboneert op Cinemapps krijgt u maandelijks een nieuwsbrief via de email!";
            SR97 = "Het zal informatie geven over toekomende films, evenementen, kortingen en ander nieuws over onze geliefde bioscoop!";
            SR98 = "Welkom bij Sally's! De prijzen zijn in $$$";
            SR99 = "Thee (Tea)";
            SR100 = "Koffie (Coffee)";
            SR101 = "Frisdrank (Soda)";
            SR102 = "Bier (Beer)";
            SR103 = "Wijn (Wine)";
            SR104 = "Kleine Popcorn (Small Popcorn)";
            SR105 = "Middel Popcorn (Medium Popcorn)";
            SR106 = "Grote Popcorn (Big Popcorn)";
            SR107 = "Suikerspin (Cotton Candy)";
            SR108 = "Grote suikerspin (Big Cotton Candy)";
            SR109 = "Kleine Ben & Jerry's (Small Ben & Jerry's)";
            SR110 = "Grote Ben & Jerry's (Big Ben & Jerry's)";
            SR111 = "Dunkin Donuts set van 3 (Dunkin Donuts set of 3)";
            SR112 = "Dunkin Donuts set van 6 (Dunkin Donuts set of 6)";
            SR113 = "Druk op een toets om te bestellen";
            SR114 = "Kies alstublieft uw betaaloptie";
            SR115 = "Wat wilt u bestellen? Denk erom om hoofdletters te gebruiken!!! (Bestel in het Engels)\n";
            SR116 = "U zal $";
            SR117 = " moeten betalen!";
            SR118 = "Om terug te gaan naar het hoofdmenu, druk op Enter";
            SR119 = "Dit zijn de huidige abbonomenten";
            SR120 = "Naam van de film: ";
            SR121 = "Er is al een film met die naam";
            SR122 = "Film beschrijving: ";
            SR123 = "Film duur (minuten): ";
            SR124 = "Film genre: ";
            SR125 = "Voer de naam in van de film die u wilt weghalen: ";
            SR126 = "[8] - Taal";
            SR127 = "[4] - Sally's Café";
            SR128 = "[5] - Contact Informatie";
            SR129 = "[6] - Film Toevoegen";
            SR130 = "[7] - Film Weghalen";
            SR131 = "[8] - Abbonomenten";
            SR132 = "[9] - Afsluiten";
            SR133 = "is";
            SR134 = "Typ in: 'English' om de taal te veranderen naar Engels (English)\nTyp iets anders in om Nederlands te behouuden als de taal\n";
            SR135 = "[9] - Taal";
            SR136 = "[10] - Afsluiten";
            SR137 = "50 jaar of ouder";
        }
        else if(languageSwitch == "English")
        {
            SR1 = "Enter the row of the seat you want to reserve";
            SR2 = "Enter the column of the seat you want to reserve";
            SR3 = "Unavailible seat, try again.";
            SR4 = "Type OK to confirm reservation, type anything else to select another seat.";
            SR5 = "IDEAL (option 1)";
            SR6 = "Credit Card (option 2)";
            SR7 = "Please enter your IDEAL information";
            SR8 = "Please enter your Credit Card information";
            SR9 = "Payment completed";
            SR10 = "The price for";
            SR11 = "At what time does the movie play?";
            SR12 = "At which date does the movie play?";
            SR13 = "Please enter the password: ";
            SR14 = "Wrong input. Please try again";
            SR15 = "Are you an Admin or User? [A/U]";
            SR16 = "To go back to the main menu, please press Enter.";
            SR17 = "Phone number: 06123456789";
            SR18 = "Email: cinemapp@hr.nl\n";
            SR19 = "Welcome to the current movies page!";
            SR20 = "Please press 1 to go ot the information page\nPress 2 to exit ";
            SR21 = "input invalid please try again";
            SR22 = "Friday - 'Horror Movie Night!'\n     All horror movies will be available to watch for 50% off " +
                    "during this event!";
            SR23 = "Saturday - 'Family Day!'\n     Each family that arrives at our cinema gets a " +
                    "free ticket to spend on food and beverages as they like!";
            SR24 = "Sunday - 'Premiere Night!'\n     On this day, one or more movies from the " +
                    "'Upcoming Movies' list will be shown for the first time in our cinema! Don't miss it!";
            SR25 = "Welcome to the upcoming movies page!";
            SR26 = "Welcome to the events page!";
            SR27 = "Welcome to Sally's Café!";
            SR28 = "Goodbye";
            SR29 = "False input. Try again.";
            SR30 = "[1] - Current Movies";
            SR31 = "[2] - Upcoming Movies";
            SR32 = "[3] - Movie Prices";
            SR33 = "[4] - Events";
            SR34 = "[5] - Sally's Café";
            SR35 = "[6] - Contact information";
            SR36 = "[7] - Subscriptions";
            SR37 = "Please choose an option to continue.";
            SR38 = "These are the upcoming Movies: ";
            SR39 = "Please type your choice 1 to fill in information. 2 to write the new information to the json file\n 3 to get information from the json file. 4 to exit";
            SR40 = "What can I help you with today?";
            SR41 = "1) Display Food & Drink menu";
            SR42 = "2) Display payment options";
            SR43 = "3) Order from Food & Drink menu";
            SR44 = "4) Exit\n";
            SR45 = "Please select your option";
            SR46 = "These are the payment options\n";
            SR47 = "1) IDEAL";
            SR48 = "2) Credit Card";
            SR49 = "Your choice is: ";
            SR50 = "You have succesfully ordered ";
            SR51 = "We don't seem to have that item. Please try again.";
            SR52 = "Thank you for visiting Sally's Café";
            SR53 = "Enter your selection please: \n";
            SR54 = "Movie not found";
            SR55 = "Below age 12";
            SR56 = "Age 12 to 26";
            SR57 = "Age 27 to 50";
            SR58 = "The prices are as follows: ";
            SR59 = "Please choose your age group";
            SR60 = "Press 1 if you are below 12 years old\nPress 2 if you are between 12 and 26 years old\nPress 3 if you are between 27 and 50 years old\nPress 4 if you are 50 years or older";
            SR61 = "This group member ";
            SR62 = "and is below 12 years old. ";
            SR63 = "and is between 12 and 26 years old. ";
            SR64 = "and is between 27 and 50 years old. ";
            SR65 = "and is 50 years or older. ";
            SR66 = "You are ";
            SR67 = "and you are below 12 years old. ";
            SR68 = "and you are between 12 and 26 years old. ";
            SR69 = "and you are between 27 and 50 years old. ";
            SR70 = "and you are 50 years or older. ";
            SR71 = "We want to ask you to pay for the reservation of the movie: ";
            SR72 = "We are calculating your Bill";
            SR73 = "Please choose a payment option";
            SR74 = "Please enter your IDEAL information, 8 digit code\n *********************";
            SR75 = "Please try again, you seemed to have typed the wrong code";
            SR76 = "Please enter your Credit Card information, 8 digit code\n *********************";
            SR77 = "Everything has been payed for";
            SR78 = "Enter the name of the movie you want to make a reservation for: ";
            SR79 = "Reservation for ";
            SR80 = "made. Your seats are: ";
            SR81 = "The prices are as follows:";
            SR82 = "For our COVID-19 Regulations please press 'C'\nFor our regularly scheduled events press 'E'";
            SR83 = "Due to the current circumstances and the social distancing order, Cinemapps has unfortunately had to" +
                    " close their doors for a short while.";
            SR84 = "However, since reopening we have been trying our hardest to get back to how things used to be," +
                    " with some added changes to uphold the new rules.\n\nAs such, we've had to remove some of our previous events" +
                    " and swap them out in favor of new ones that don't put a lot of people at risk. ";
            SR85 = "We are sorry for the inconvenience and hope for your understanding.";
            SR86 = "Press any key to go back to the Events page";
            SR87 = "Current ongoing events:";
            SR88 = "Welcome to the subscriptions page!";
            SR89 = "Press 'S' to subscribe,\n'I' for more information,\n'Enter' to go back to the main menu";
            SR90 = "Thank you for choosing to subscribe to the Cinemapps newsletter! Please enter the following information:";
            SR91 = "First name: ";
            SR92 = "Surname: ";
            SR93 = "Age: ";
            SR94 = "Email: ";
            SR95 = "Press any key to go back to the subscription page";
            SR96 = "If you subscribe to Cinemapps, you will receive a monthly news letter by email!";
            SR97 = "It will include information about upcoming movies, events, and eventual discounts, as well as any other news surrounding our beloved cinema!";
            SR98 = "Welcome to Sally's! Prices are in $$$";
            SR99 = "Tea";
            SR100 = "Coffee";
            SR101 = "Soda";
            SR102 = "Beer";
            SR103 = "Wine";
            SR104 = "Small Popcorn";
            SR105 = "Medium Popcorn";
            SR106 = "Big Popcorn";
            SR107 = "Cotton Candy";
            SR108 = "Big Cotton Candy";
            SR109 = "Small Ben & Jerry's";
            SR110 = "Big Ben & Jerry's";
            SR111 = "Dunkin Donuts set of 3";
            SR112 = "Dunkin Donuts set of 6";
            SR113 = "Press any key to order";
            SR114 = "Please choose your payment option";
            SR115 = "What would you like to order? Remember to use Capital Letters!!!\n";
            SR116 = "You will have to pay $";
            SR117 = "!";
            SR118 = "To go back to the main menu, please press Enter";
            SR119 = "These are the current subscribers:\n";
            SR120 = "Name of the movie: ";
            SR121 = "A movie with that name already exists";
            SR122 = "Movie description: ";
            SR123 = "Movie length (minutes): ";
            SR124 = "Movie genre: ";
            SR125 = "Enter the name of the movie you want to remove: ";
            SR126 = "[8] - Language";
            SR127 = "[4] - Sally's Café";
            SR128 = "[5] - Contact Information";
            SR129 = "[6] - Add Movie";
            SR130 = "[7] - Remove Movie";
            SR131 = "[8] - Subscriptions";
            SR132 = "[9] - Quit";
            SR133 = "is";
            SR134 = "Enter Nederlands to switch language to Dutch (Nederlands)\nEnter anything else to keep English as the language\n";
            SR135 = "[9] - Language";
            SR136 = "[10] - Quit";
            SR137 = "50+";
}
        Login.Question();

    

           



        





    }
}

