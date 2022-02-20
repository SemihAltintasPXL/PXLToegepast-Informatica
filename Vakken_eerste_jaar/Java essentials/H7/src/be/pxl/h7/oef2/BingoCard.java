package be.pxl.h7.oef2;

import java.util.ArrayList;

public class BingoCard {
    private String name;
    private ArrayList<Integer> numbers;

    public BingoCard(String name) {
        this.name = name;
        numbers = new ArrayList<Integer>();
    }

    public void addNumber(int number) {
        numbers.add(number);
    }

    public boolean hasNumber(int number) {
        for (int n : numbers) {
            if (number == n) {
                return true;
            }
        }
        return false;
    }
    public String toString(){
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.append(String.format("%s (", name));
        stringBuilder.append(numbers.toString().substring(1, numbers.toString().length() - 1));
        stringBuilder.append(")");
        //stringBuilder.append("\n");
        return stringBuilder.toString();

    }
}