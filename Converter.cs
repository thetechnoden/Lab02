class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double ConvertToUSD(double uah)
    {
        return uah / usd;
    }

    public double ConvertToEUR(double uah)
    {
        return uah / eur;
    }

    public double ConvertToPLN(double uah)
    {
        return uah / pln;
    }

    public double ConvertFromUSD(double amountInUSD)
    {
        return amountInUSD * usd;
    }

    public double ConvertFromEUR(double amountInEUR)
    {
        return amountInEUR * eur;
    }

    public double ConvertFromPLN(double amountInPLN)
    {
        return amountInPLN * pln;
    }
}