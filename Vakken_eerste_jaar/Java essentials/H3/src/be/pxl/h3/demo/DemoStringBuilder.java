package be.pxl.h3.demo;

public class DemoStringBuilder {
    public static void main(String[] args) {
        // String += ""
        long a = System.currentTimeMillis();
        String k = "pizza";
        for(int i=0;i<10000;i++) {
            k += "pizza";
        }
        System.out.println(k);
        long b = System.currentTimeMillis();

        // StringBuilder
        long c = System.currentTimeMillis();
        StringBuilder builder = new StringBuilder();
        for(int i=0;i<10000;i++) {
            builder.append("pizza");
        }
        System.out.println(builder.toString());
        long d = System.currentTimeMillis();

        // Result
        System.out.println("Time with String += : " + (b-a) + "ms");
        System.out.println("Time with StringBuilder : " + (d-c) + "ms");
    }
}
