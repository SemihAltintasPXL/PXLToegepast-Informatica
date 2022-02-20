package be.pxl.h2.oef3;

public class Character {
    private static final int MAX_TITLES = 3;
    private static int count = 0;

    private String firstName;
    private String lastName;
    private String nickName;
    private String house;
    private int firstSeason;
    private int lastSeason;
    private int episodes;
    private String potrayedBy;
    private int nuberOfTitles;
    private String[] titles = new String[MAX_TITLES];

    public Character(String firstName, String lastName, String house, String potrayedBy){
        this(firstName, lastName, "", house, potrayedBy);
    }
    public Character(String firstName, String lastName, String nickName, String house, String potrayedBy){
        this(firstName, lastName, nickName, house, 0, 0, 0, potrayedBy);
    }

    public Character(String firstName, String lastName, String nickName, String house, int firstSeason, int lastSeason, int episodes, String potrayedBy){
        this.firstName = firstName;
        this.lastName = lastName;
        this.nickName = nickName;
        this.house = house;
        this.firstSeason = firstSeason;
        this.lastSeason = lastSeason;
        this.episodes = episodes;
        this.potrayedBy = potrayedBy;
        count++;
    }
    public void setData(int firstSeason, int lastSeason, int episodes){
        this.firstSeason = firstSeason;
        this.lastSeason = lastSeason;
        this.episodes = episodes;
    }
    public void addTitle(String title){
        if (nuberOfTitles < MAX_TITLES){
            titles[nuberOfTitles] = title;
            nuberOfTitles++;
        }
    }
    public String toString(){
        String output = "";
        if (nickName == null || nickName.equals("")){
            output += String.format("%s %s of house %s%n", firstName, nickName, lastName);
        }
        else {
            output += String.format("%s \"%s\" %s of house %s%n", firstName, nickName, lastName, house);
        }

        for (String title : titles){
            if (title != null){
                output += String.format("*** \"%s\"%n", title);
            }
        }
        output += "Played by: " + potrayedBy;

        if (episodes > 0) {
            output += String.format(" in season %d-%d (%d episodes)", firstSeason, lastSeason, episodes);
        }
        return output;
    }
    public static int getCount(){
        return count;
    }




}
