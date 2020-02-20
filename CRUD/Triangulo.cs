using System;

public class Triangulo  
{
	public Double Triangulo(Double A, Double B, Double C)
	{
	        double p = (A + B + C) / 2.0;
	        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
     }
}
