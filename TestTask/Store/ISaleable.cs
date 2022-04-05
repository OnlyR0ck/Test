namespace TestTask.Computer
{
    public interface ISaleable
    {
        public string Id { get; }

        public float GetPrice();

        public string GetCharacteristics();
    }
}