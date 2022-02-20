getal1 = 1
getal2 = 1
print(getal1, getal2, "", end="")
volgend_getal = getal1 + getal2
while volgend_getal < 1500:
    print(volgend_getal, "", end="")
    getal1 = getal2
    getal2 = volgend_getal
    volgend_getal = getal1 + getal2
