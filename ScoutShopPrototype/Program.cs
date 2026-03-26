Provider provider = new Provider("ASB");
Insignia insignia1 = new Insignia("Fuego y Campamento", 5.52m, "Azul", provider);
Insignia insignia2 = (Insignia)insignia1.Clonar();
insignia2.Provider.Name = "DSC";

Console.WriteLine(insignia1.Provider.Name);
Console.WriteLine(insignia2.Provider.Name);
