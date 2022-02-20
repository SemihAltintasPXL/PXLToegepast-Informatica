''' Wat kost mijn auto? Prijsbewuste personen willen weten hoeveel hun auto echt kost. Achtereenvolgens wordt ingevoerd:

aantal afgelegde km per jaar (afgelegde_km)
verbruik in l per 100 km (verbruik)
prijs van 1 l brandstof (prijs_per_liter)
Als uitvoer wordt verwacht:

de totale kosten per jaar voor het opgegeven aantal km
de kostprijs per km rijden.'''

afgelegde_km = float(input("aantal afgelegde km per jaar: "))
verbruik = float(input("verbruik in l per 100km: "))
prijs_per_liter = float(input("prijs van 1 l brandstof: "))

kostprijs_per_km = (verbruik / afgelegde_km) * prijs_per_liter
totale_kost_per_jaar = afgelegde_km * kostprijs_per_km

print("De totale kost per jaar bedraagt ", totale_kost_per_jaar)

print("De kostprijs per km bedraagt ", kostprijs_per_km)
