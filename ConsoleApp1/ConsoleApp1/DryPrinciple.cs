namespace ConsoleApp1
{
    #region Extrating common code into Methods
    internal class DryPrinciple
    {
        public void CalculateWithoutDry()
        {
            int a = 5;
            int b=6;
            int x = 10;
            int y = 20;

            int sumOfab = a + b;
            int sumOfxy=x+ y;
        }

        //Follow DRY Principle
        public void CalculateWithDry()
        {
            int a = 5;
            int b = 6;
            int x = 10;
            int y = 20;

            int sumOfab = Add(a,b);
            int sumOfxy = Add(x, y);
        }
        private int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    #endregion

    #region  Creating reuseable classes or components

    /// <summary>
    /// Without DRY Principle
    /// </summary>
    //public class Rectangle
    //{
    //    public int Height { get; set; }
    //    public int Width { get; set; }
    //    public int CalculateArea()
    //    {
    //        return Width * Height;
    //    }

    //    public int CalculatePerimeter()
    //    {
    //        return 2 * (Width + Height);
    //    }
    //}

    ////With DRY Principle
    public class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Square : Rectangle
    {
        public int CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }
    #endregion


    #region Utilizing inheritance and Interfaces

    //public class Animal
    //{
    //    public void Eat() { }
    //    public void Sleep() { }
    //}

    //public class Dog
    //{
    //    public void Eat() { }
    //    public void Sleep() { }
    //}

    //public class Cat
    //{
    //    public void Eat() { }
    //    public void Sleep() { }
    //}

    // Wih DRY Principle

    public interface IAnimal
    {
        void Eat();
        void Sleep();
    }
    public class Dog : IAnimal
    {
        public void Eat() {
        
        }
        public void Sleep() {
        
        }

        // Specific behaviour of Dog
    }

    public class Cat : IAnimal
    {
        public void Eat() { }
        public void Sleep() { }

        // Specific behaviour of Dog
    }

    #endregion
}
