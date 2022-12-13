namespace Inheritance.Example;
class Reactangle : IShape
{
    public Reactangle(float l, float b)
    {
        length = l;
        width = b;
    }

    float length;
    float width;

    public float GetArea() => length * width;
    public float GetPerimeter() => 2 * (length + width);
}
