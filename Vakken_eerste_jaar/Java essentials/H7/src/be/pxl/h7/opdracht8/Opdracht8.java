package be.pxl.h7.opdracht8;

public class Opdracht8 {
    public static void main(String[] args) {

        int[][] matrix = new int[4][6];

        for(int i=0;i< matrix.length;i++) {
            for(int j=0;j< matrix[i].length;j++) {
                matrix[i][j] = (i+1)*(j+1);
            }
        }

        for(int[] row:matrix) {
            for(int e:row) {
                System.out.printf("%4d",e);
            }
            System.out.println();
        }
    }
}
