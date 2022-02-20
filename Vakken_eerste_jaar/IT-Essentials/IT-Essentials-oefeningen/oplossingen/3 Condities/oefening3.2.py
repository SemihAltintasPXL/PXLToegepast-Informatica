brutoloon = int(input("Geef het brutoloon in: "))

vakantiegeld = brutoloon * 0.05

if vakantiegeld < 350:
    jaarlijkse_bijdrage = vakantiegeld * 0.08
else:
    jaarlijkse_bijdrage = 350 * 0.08

print("Het brutoloon:", brutoloon, "\nVakantiegeld:", vakantiegeld, "\nJaarlijkse bijdrage:", jaarlijkse_bijdrage)