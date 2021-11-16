namespace Lesson10
{
    public class MyItem
    {
        private int _age;

        public string Name { get; set; }

        public MyItem(int age)
        {
            _age = age;
        }

        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

    }
}