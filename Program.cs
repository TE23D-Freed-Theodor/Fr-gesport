int points = 0;

Console.WriteLine("Detta är en frågesport om spelet \"Call of War\". \nDu kommer att få tre svarsalternativ, och svara genom att skriva 1, 2 eller 3\nSkriv 1 och tryck enter om du har förstått instruktionerna!");
string start_game = Console.ReadLine();

if (start_game == "1") {
    Console.WriteLine("\n\n\nFråga 1: Vilken byggnad används för att producera bland annat anti-air? \n1 - Ordnance Foundry \n2 - Secret Lab \n3 - Aircraft Factory");
    string fråga1 = Console.ReadLine();

    if (fråga1 == "1") {Console.WriteLine("\nKorrekt!\n"); points++;}
    else {Console.WriteLine("Inkorrekt! Det rätta svaret var 1\n\n\n");}

    Console.WriteLine("Vilken av följande är INTE en försvarsenhet?\n1 - Armored car\n2 - Tank Destroyer\n3 - Medium tank");
    string fråga2 = Console.ReadLine();
    if (fråga2 == "3") {Console.WriteLine("\nKorrekt!\n"); points++;}
    else { Console.WriteLine("Inkorrekt! Det rätta svaret var 3\n\n\n");}

    Console.WriteLine("Vilken båt används mot submarines? \n1 - Cruisers\n2 - Destroyers\n3 - Battleships");
    string fråga3 = Console.ReadLine();
    if (fråga3 == "2") {Console.WriteLine("\nKorrekt!\n"); points++;}    else { Console.WriteLine("Inkorrekt! Det rätta svaret var 2\n\n\n");}

    Console.WriteLine("Vilken är den snabbaste landenheten? \n1 - Mechanised infantry\n2 - Light tanks\n3 - Motorized infantry");
    string fråga4 = Console.ReadLine();
    if (fråga4 == "3") {Console.WriteLine("\nKorrekt!\n"); points++;}    else { Console.WriteLine("Inkorrekt! Det rätta svaret var 3\n\n\n");}
   
    Console.WriteLine("Hur många doktriner finns i Call of War? \n1 - Fyra\n2 - Tre\n3 - Fem");
    string fråga5 = Console.ReadLine();
    if (fråga5 == "1") {Console.WriteLine("\nKorrekt!\n"); points++;}    else { Console.WriteLine("Inkorrekt! Det rätta svaret var 1\n\n\n");}

    Console.WriteLine("Vilken doktrin har billigast enheter? \n1 - Comintern\n2 - Pan-asian\n3 - Allies");
    string fråga6 = Console.ReadLine();
    if (fråga6 == "1") {Console.WriteLine("\nKorrekt!\n"); points++;}    else { Console.WriteLine("Inkorrekt! Det rätta svaret var 1\n\n\n");}
 
    Console.WriteLine("Vilken är den starkaste artillerienheten? \n1 - Rocket Artillery\n2 - Railroad Guns\n3 - SP artillery");
    string fråga7 = Console.ReadLine();
    if (fråga7 == "2") {Console.WriteLine("\nKorrekt!\n"); points++;}    else { Console.WriteLine("Inkorrekt! Det rätta svaret var 2\n\n\n");}

    Console.WriteLine("Vilken enhet gör mest skada (trick question)? \n1 - Nuclear bomber\n2 - Nuclear Rocket\n3 - Tactical bombers");
    string fråga8 = Console.ReadLine();
    if (fråga8 == "2") {Console.WriteLine("\nKorrekt!\n"); points++;}    else { Console.WriteLine("Inkorrekt! Det rätta svaret var 2\n\n\n");}

    Console.WriteLine("Vad är annorlunda med strategic bombers?? \n1 - De gör mycket skada på byggnader\n2 - Det är den minst populära enheten då de kostar 3200 rare materials\n3 - De gör särskilt mycket skada SPECIFIKT på armored cars");
    string fråga9 = Console.ReadLine();
    if (fråga9 == "1") {Console.WriteLine("\nKorrekt!\n"); points++;}    else { Console.WriteLine("Inkorrekt! Det rätta svaret var 1\n\n\n");}

    Console.WriteLine("Hur mycket guld får man från att kolla på en reklam? \n1 - 20\n2 - 10\n3 - 850 \n4 - 15\n5 - 5");
    string fråga10 = Console.ReadLine();
    if (fråga10 == "3") {Console.WriteLine("\nKorrekt!\n"); points++;}    else { Console.WriteLine("Inkorrekt! Det rätta svaret var 3\n\n\n");}

    Console.WriteLine($"Du fick {points} poäng! Grattis! Du suger!");
    Console.WriteLine("");  

    Console.WriteLine("""
    .___  .__                       _________        .__  .__            _____   __      __             
    |   | |  |   _______  __ ____   \_   ___ \_____  |  | |  |     _____/ ____\ /  \    /  \_____ _______ 
    |   | |  |  /  _ \  \/ // __ \  /    \  \/\__  \ |  | |  |    /  _ \   __\  \   \/\/   /\__  \\_  __ \
    |   | |  |_(  <_> )   /\  ___/  \     \____/ __ \|  |_|  |__ (  <_> )  |     \        /  / __ \|  | \/
    |___| |____/\____/ \_/  \___  >  \______  (____  /____/____/  \____/|__|      \__/\  /  (____  /__|   
                                \/                 \/                                  \/        \/       
    """);
    Console.ReadLine();
}

