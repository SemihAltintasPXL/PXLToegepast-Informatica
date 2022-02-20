# bereken de som van een reeks getallen: invoer stopt bij ingave 0

som = 0
getal = int(input("geef een geheel getal in"))
while getal != 0:  # while betekent zolang
    som += getal  # som = som + getal
    getal = int(input("geef een geheel getal in"))  # deze invoer na da lus altijd zetten
print("de som van deze getallen is", som)  # de som helemaal onder aan afdrukken

# extra opgave: bereken het product van een reeks getallen. Invoer stopt bij ingave 0.

prod = 1  # product op 1 initialiseren en niet 0, want anders is de uitkomst altijd 0 want 0 * iets = 0
getal = int(input("geef een geheel getal in"))
while getal != 0:  # while betekent zolang
    prod *= getal  # prod = prod* getal
    getal = int(input("geef een geheel getal in"))
print("de som van deze getallen is", som)
