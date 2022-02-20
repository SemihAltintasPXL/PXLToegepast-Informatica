'''Schrijf code die een hoeveelheid centen (opgeslagen in een variabele met de naam bedrag) classificeert als een combinatie van grotere geldstukken.
Je code gebruikt 2 euro's (200 centen), euro's (100 centen), 50 centen, 20 centen, 10 centen, 5 centen, 2 centen en centen (1 cent).
Het resultaat is dat je het bedrag uitdrukt in het minimale aantal muntjes dat nodig is.

Voorbeeld: 359 centen = 1  ×  2 euro, 1  ×  1 euro, 1  ×  50 cent, 0  ×  20 cent, 0  ×  10 cent, 1  ×  5 cent, 2  ×  2 cent en 0  ×  1 cent.'''

bedrag = int(input("Vul een bedrag in (in centen) "))

aantal_2euro=bedrag//200
bedrag= bedrag%200

aantal_1euro=bedrag//100
bedrag= bedrag%100

aantal_50cent= bedrag//50
bedrag=bedrag%50

aantal_20cent=bedrag//20
bedrag=bedrag%20

aantal_10cent=bedrag//10
bedrag=bedrag%10

aantal_5cent=bedrag//5
bedrag=bedrag%5

aantal_2cent=bedrag//2
bedrag=bedrag%2

aantal_1cent=bedrag//1
bedrag=bedrag%1


print(bedrag,"centen= ",aantal_2euro,"x 2 euro,",aantal_1euro,"x 1 euro, ", aantal_50cent,"x 50cent,",aantal_20cent,
"x 20 cent,",aantal_10cent,"x 10 cent,",aantal_5cent,"x 5 cent, ", aantal_2cent,"x 2  cent, ",aantal_1cent,"x 1 cent")



