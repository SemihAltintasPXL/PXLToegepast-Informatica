# maak volgende driehoek
# 1 2 3 4 5
# 1 2 3 4
# 1 2 3
# 1 2
# 1

for i in range(1, 6):
    for j in range(1, 7 - i):  # omdat je die 'i' ervan aftrekt is de eindgrens 7 en niet 6
        print(j, end="\t")  # end = "\t" is tab , om het mooi uit te lijnen
    print()
