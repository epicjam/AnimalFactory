namespace ConsoleApp1 
{
    public class New 
    {
        public static void Main(string[] args)
        {
            AnimalFactory animal = new AnimalFactory();
            animal.CreateAnimal(AnimalType.Monkey);
        }
    }
}