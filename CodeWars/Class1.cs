﻿using System;

public class Class1
{
    public static string Bmi(double weight, double height)
    {
        var bmi = weight / (height * height);
        if (bmi <= 18.5)
        {
            return "Underweight";
        }
        if (bmi <= 25.0)
        {
            return "Normal";
        }
        if (bmi <= 30.0)
        {
            return "Overweight";
        }
        if (bmi > 30)
        {
            return "Obese";
        }
        return null;
    }
}
