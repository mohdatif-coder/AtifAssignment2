namespace AtifAssignment2;


public static class Triangle
{
    public static string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle)
    {

        // Check for invalid triangle (any side length is zero)
        if (firstAngle == 0 || secondAngle == 0 || thirdAngle == 0)
        {
            return "Invalid triangle: One or more sides have zero length";
        }

        // Check if the sum of any two sides is less than or equal to the third side
        if (firstAngle + secondAngle <= thirdAngle || secondAngle + thirdAngle <= firstAngle || firstAngle + thirdAngle <= secondAngle)
        {
            return "Invalid triangle: Sum of two sides must be greater than the third side";
        }

        // Classify the triangle
        if (firstAngle == secondAngle && secondAngle == thirdAngle)
        {
            return "Equilateral";
        }
        else if (firstAngle == secondAngle || secondAngle == thirdAngle || firstAngle == thirdAngle)
        {
            return "Isosceles";
        }
        else
        {
           return "Scalene";
        }

    }
}



