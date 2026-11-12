namespace P3ImplementClasses;

public static class AccountCalculations
{
    // Intérêts composés
    public static double CalculateCompoundInterest(double principal, double annualRate, double years)
    {
        return principal * Math.Pow(1 + annualRate, years) - principal;
    }

    // Valide le numéro de compte
    public static bool ValidateAccountNumber(int accountNumber)
    {
        return accountNumber.ToString().Length == 8;
    }

    // Frais de transaction (chèque de banque, virement)
    public static double CalculateTransactionFee(double amount, double transactionRate, double maxTransactionFee)
    {
        double fee = amount * transactionRate;
        return Math.Min(fee, maxTransactionFee);
    }

    // Frais de découvert
    public static double CalculateOverdraftFee(double amountOverdrawn, double overdraftRate, double maxOverdraftFee)
    {
        double fee = amountOverdrawn * overdraftRate;
        return Math.Min(fee, maxOverdraftFee);
    }

    // Conversion de devise
    public static double ReturnForeignCurrency(double amount, double exchangeRate)
    {
        return amount * exchangeRate;
    }
}