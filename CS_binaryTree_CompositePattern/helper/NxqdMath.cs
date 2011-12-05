namespace CS_binaryTree_CompositePattern.helper
{
    public static class NxqdMath
    {
        public static bool IsPrime(int number)
        {
            // remove all even numbers
            if ((number & 1) == 0)
            {
                if (number == 2)
                    return true;
                return false;
            }
            for (int i = 3; (i*i) <= number; i += 2)
            {
                if ((number%i) == 0)
                {
                    return false;
                }
            }
            return number != 1;
        }
    }
}