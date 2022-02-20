package be.pxl.extra.project2;

public class OnlineSpel extends Spel{
    private String genre;
    private String url;

    public OnlineSpel(String naam, Uitgever uitgever) {
        super(naam, uitgever);
    }

    public String getGenre() {
        return genre;
    }

    public void setGenre(String genre) {
        this.genre = genre;
    }

    public String getUrl() {
        return url;
    }

    public void setUrl(String url) {
        this.url = url;
    }
    public String toString(){
        return String.format("OnlineSpel{naam='%s',minimumLeeftijd=%d,uitgever=%s,genre='%s',url=%s}",super.getNaam(),super.getMinimumLeeftijd(),super.toString(),genre,url);
    }
}
