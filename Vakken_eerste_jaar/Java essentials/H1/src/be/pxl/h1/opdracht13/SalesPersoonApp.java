package be.pxl.h1.opdracht13;

public class SalesPersoonApp {
    public static void main(String[] args) {
        SalesPersoon salesPersoon = new SalesPersoon();

        salesPersoon.setMonthlySale(0, 17000);
        salesPersoon.setMonthlySale(1, 13000);
        salesPersoon.setMonthlySale(2, 3000);

        System.out.println(salesPersoon.getTotalSales());
        System.out.println(salesPersoon.getAverageSale());
    }
}
