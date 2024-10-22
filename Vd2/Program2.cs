internal class Program
{
    private static void Main(string[] args)
    {
        // Circle circle1 = new Circle(3);
        // Rectangle rectangle1 = new Rectangle(3,3);
        // if (circle1.GetArea() < rectangle1.GetArea()) 
        // {
        //     System.Console.WriteLine("Dien tich hinh tron nho hon hinh vuong");
        // }
        // else
        // {
        //     System.Console.WriteLine("Dien tich hinh tron lon hon hinh vuong");
        // }

        System.Console.Write("Nhap ban kinh hinh tron: ");
        float x = float.Parse(Console.ReadLine());
        System.Console.Write("Nhap chieu rong hinh chu nhat: ");
        float y = float.Parse(Console.ReadLine());
        System.Console.Write("Nhap chieu cao hinh chu nhat: ");
        float z = float.Parse(Console.ReadLine());
        Circle circle2 = new Circle(x);
        Rectangle rectangle2 = new Rectangle(y,z);
        ComparatorCircleandRectangle(circle2.GetArea(), rectangle2.GetArea());
    }
    private static void ComparatorCircleandRectangle(float circleArea, float recArea)
    {
        System.Console.WriteLine("Dien tich hinh tron " + MathF.Round((circleArea),2));
        System.Console.WriteLine("Dien tich hinh chu nhat " + Math.Round((recArea),2));
        if (circleArea < recArea)
        {
            System.Console.WriteLine("Dien tich hinh tron nho hon hinh vuong");
        }
        else
        {
            System.Console.WriteLine("Dien tich hinh tron lon hon hinh vuong");
        }
    }
}