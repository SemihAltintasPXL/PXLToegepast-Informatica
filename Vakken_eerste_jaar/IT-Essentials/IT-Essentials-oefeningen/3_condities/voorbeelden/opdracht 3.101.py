# bmi <18, >=18 en <25, >=25 en <30, >=30 en <40, >=40

lengte = int(input("geef je lenge in cm in")) / 100
gewicht = float(input("geef je gewicht in kg "))
bmi = gewicht / (lengte * lengte)

if bmi < 18:
    print("ondergewicht")
elif bmi < 25:  # niet oké : elif bmi >= 18 and bmi < 25    anders dubbele testing voor niks
    print("oké")
elif bmi < 30:
    print("overgewicht)")
elif bmi < 40:
    print("obesitas")
else:  # niet oké elif bmi >=40      anders dubbele testing voor niks
    print("ziekelijk overgewicht")
