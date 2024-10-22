public class Rectangle
{
    float width = 0;
    float height = 0;
    public Rectangle(float width, float height)
    {
        this.width = width;
        this.height = height;
    }
    public float GetArea()
    {
        return width * height;
    }
    public float GetPerimeter()
    {
        return (width + height)*2;
    }
}