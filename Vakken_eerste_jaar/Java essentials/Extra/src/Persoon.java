public abstract class Persoon {
    private String id;
    private String naam;

    public Persoon(String id, String naam) {
        StringBuilder stringBuilder = new StringBuilder();
        for (Character character : id.toCharArray()){
            if (Character.isDigit(character)){
                stringBuilder.append(character);
            }
            else if (Character.isAlphabetic(character)){
                stringBuilder.append(Character.toUpperCase(character));
            }
            id = stringBuilder.toString();
            if (id.length() >= 3){
                id = id.substring(0, 3);
            }

        }
        this.naam = naam;
        this.id = id;
    }
    public String getId() {
        return id;
    }

    public String getNaam() {
        return naam;
    }
}
