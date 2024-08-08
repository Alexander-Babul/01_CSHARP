double CalculateFormula(int a, int b, int c, int d)
{
    double Nominator = a * b;
    int Denaminator = c +d;
    double result = Nominator / Denaminator;
    return result;
}

double result = CalculateFormula(1,2,3,4);
Console.WriteLine(result);