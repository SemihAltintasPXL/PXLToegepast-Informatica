package be.pxl.h3.opdracht6;

public class Opdracht6 {
    public static void main(String[] args) {
        String s = "Hallo allemaal";
        System.out.println(s + " " + s.length());

        s = s.replace('a', 'o');
        System.out.println(s);

        int count = 0;
        /*for(char c : s.toCharArray()) {
            if(c == 'e') {
                count++;
            }
        }*/
        for(int i=0;i<s.length();i++) {
            char c = s.charAt(i);
            if(c == 'e') {
                count++;
            }
        }

        System.out.println("E's: " + count);

        String andere = "andere";
        System.out.println("Gelijk? " + andere.equals(s));

        // pizza [5/2 = 2
        // pizzza
        String woord = "oooooo";
        int capsFrom= woord.length()/2;
        int capsTo = woord.length()/2 + 1;
        if(woord.length()%2==0) {
            capsFrom = woord.length()/2 -1;
        }
        String output = "";

        output += woord.substring(0, capsFrom);
        output += woord.substring(capsFrom, capsTo).toUpperCase();
        output += woord.substring(capsTo);

        System.out.println(output);
    }
}
