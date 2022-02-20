def main():
    spreuk = "     AbrACdaBRA     "
    # voorloop en achterloop spaties verwijderen
    spreuk = spreuk.strip()
    print(spreuk)
    # afdrukken in hoofdletters => opgepast spreuk zelf is niet gewijzigd
    print(spreuk.upper())
    # afdrukken in kleine letters
    print(spreuk.lower())


if __name__ == '__main__':
    main()
