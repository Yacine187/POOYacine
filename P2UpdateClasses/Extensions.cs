namespace P2UpdateClasses;

public static class BankCustomerExtensions
{
    // Vérifie que l'ID client a 10 caractères
    public static bool IsValidCustomerId(this BankCustomer customer)
    {
        return customer.CustomerId.Length == 10;
    }

    // Salue le client
    public static string GreetCustomer(this BankCustomer customer)
    {
        return $"Hello, {customer.ReturnFullName()}!";
    }
}

public static class BankAccountExtensions
{
    // Vérifie si le compte est à découvert
    public static bool IsOverdrawn(this BankAccount account)
    {
        return account.Balance < 0;
    }

    // Vérifie si un montant peut être retiré
    public static bool CanWithdraw(this BankAccount account, double amount)
    {
        return account.Balance >= amount;
    }
}