public static class IntegerTool
{
    extension(int source)
    {
        public int DigitsCount()
        {

            return run(source);
            int run(int s)
            {
                if (s < 10) return 1;

                var d = s / 10;

                return 1 + run(d);
            }
            
        }
    }
}
