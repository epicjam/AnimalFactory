namespace ConsoleApp1 
{
    public abstract class Animals
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string VoiceSound { get; set; }

        public Animals (string name, string voiceSound, int age)
        {
            Name = name;
            VoiceSound = voiceSound;
            Age = age;
        }

    }
}