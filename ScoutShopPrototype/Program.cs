Provider provider = new Provider("ASB");
CatalogManager catalogManager = new CatalogManager();
Insignia insignia1 = new Insignia("Fuego y Campamento", 5.52m, "Azul", provider);
catalogManager.RegisterProduct("Insignia Primer Campamento", insignia1);

Insignia insignia2 = (Insignia)catalogManager.GetClone("Insignia Primer Campamento");
insignia2.Provider.Name = "DSC";
catalogManager.RegisterProduct("Insignia Segundo Campamento", insignia2);

Console.WriteLine(((Insignia)catalogManager.GetClone("Insignia Primer Campamento")).Provider.Name);
Console.WriteLine(((Insignia)catalogManager.GetClone("Insignia Segundo Campamento")).Provider.Name);
