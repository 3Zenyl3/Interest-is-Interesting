static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0)
        {
            return 3.213f;
        }
        else if (balance < 1000&&balance>=0)
        {
            return 0.5f;
        }
        else if (balance < 5000 && balance>=1000)
        {
            return 1.621f;
        }
        else 
        {
            return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        float a = InterestRate(balance);
        return balance * ((decimal)a) / 100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        decimal a = Interest(balance);
        return balance + a;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int i = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate((decimal)balance);
            i++;
        }
        return i;
    }
}
