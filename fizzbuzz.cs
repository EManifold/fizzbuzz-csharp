namespace FizzBuzz
{

  public class FizzBuzz
  {

    public static string GetOutput(int number)
    {
      if ((number % 3 == 0) && (number % 5 == 0))
      {
        return "fibuzz"
      }
      else if (number % 3 == 0)
      {
        return "fizz"
      }
      else if (number % 5 == 0)
      {
        return "buzz"
      }
    }
  }
}
