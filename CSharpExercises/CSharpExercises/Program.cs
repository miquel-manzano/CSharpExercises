internal class Program
{
    private static void Main(string[] args)
    {
        const double BASE_FEE = 800.0;
        const int MAX_AGE = 65;
        const int MIN_AGE = 21;
        const double DISCOUNT_OVER_MAX_AGE = 0.40;
        const double DISCOUNT_UNDER_MIN_AGE = 0.25;
        const double DISCOUNT_OTHERS = 0.10;

        Console.Write("Enter your age: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            double appliedDiscount = age > MAX_AGE ? DISCOUNT_OVER_MAX_AGE :
                                     age < MIN_AGE ? DISCOUNT_UNDER_MIN_AGE :
                                     DISCOUNT_OTHERS;

            double finalFee = BASE_FEE - (BASE_FEE * appliedDiscount);
            double discountPercentage = appliedDiscount * 100;

            Console.WriteLine($"Quota Base (€): {BASE_FEE}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Applied Discount (%): {discountPercentage}");
            Console.WriteLine($"Final Fee (€): {finalFee}");
        }
    }
}