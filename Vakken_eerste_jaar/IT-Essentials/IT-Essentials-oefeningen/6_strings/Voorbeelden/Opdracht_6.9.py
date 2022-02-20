def main():
    tekst = "The quick bown fox jumps over de lazy cat"
    # vervang d door th en dan cat door dog
    nieuw = tekst.replace("d","th").replace("cat","dog")
    print(nieuw)

if __name__ == '__main__':
    main()