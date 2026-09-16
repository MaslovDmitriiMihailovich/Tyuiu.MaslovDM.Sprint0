namespace Tyuiu.MaslovDM.Sprint0.Task2.V0.Lib
{
    public class DataService
    {
public static string GetMessag(string name)
        {
            return $"Привет, {name}";
        }

        public static object GetMessage(string name)
        {
            return $"Привет..., {name}";
        }
    }
}
