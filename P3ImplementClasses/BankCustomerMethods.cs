namespace P3ImplementClasses;

public partial class BankCustomer
{
    // Retourne le nom complet du client
    public string ReturnFullName()
    {
        return $"{FirstName} {LastName}";
    }

    // Met à jour le nom du client
    public void UpdateName(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Affiche les informations du client
    public string DisplayCustomerInfo()
    {
        return $"Customer ID: {CustomerId}, Name: {ReturnFullName()}";
    }
}