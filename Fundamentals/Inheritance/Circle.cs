namespace Inheritance.Example;
class Circle : IShape
{
    float radius;

    public Circle(float r) => radius = r;

    public float GetArea() => 3.14f * radius * radius;
    public float GetPerimeter() => 2 * 3.14f * radius;   
}
