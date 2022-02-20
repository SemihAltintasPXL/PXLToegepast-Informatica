vertrek_uur = int(input("Geef het uur van vertrek: "))
vertrek_minuut = int(input("Geef het minuut van vertrek: "))
duur = int(input("Geef de duur van de vlucht: "))

vertrek_uur = vertrek_uur * 60
aankomst = vertrek_uur + vertrek_minuut + duur
aankomst_uur = aankomst // 60 % 24
aankomst_minuut = aankomst % 60

print("U komt aan om", str(aankomst_uur) + ":" + str(aankomst_minuut))