package be.pxl.h1.opdracht13;

public class SalesPersoon {
    private String name;
    private double[] verkoopscijfers;

    public void setMonthlySale(int month, double sales){
        verkoopscijfers[month] = sales;
    }

    public double getTotalSales(){
        double total = 0;
        for (double s:verkoopscijfers){
            total += s;
        }
        return total;
    }
    public double getAverageSale(){
        double total = getTotalSales();
        return total / verkoopscijfers.length;
    }
}
