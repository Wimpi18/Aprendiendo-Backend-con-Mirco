Insignia insignia1 = new Insignia("Fuego y Campamento", 5.52m, "Azul");
Insignia insignia2 = (Insignia)insignia1.Clonar();
insignia1.Name = "Agua y Campamento";

Console.Write(insignia1.Name);
Console.Write(insignia2.Name);
