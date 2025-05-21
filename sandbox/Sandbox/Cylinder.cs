class Cylinder
{
    private Circle _circle;

    private double _height;

    public Cylinder()
    {
        _height = 0.0;
        _circle = null;
    }

    public Cylinder(Circle cirlce)
    {
        _height = 0.0;
        _circle = cirlce;
    }

    // public Cylinder(Double height, Circle cirlce)
    // {
    //     _height = height;
    //     _circle = circle;
    // }

    public Cylinder(double height, double radius)
    {
        _height = height;
        _circle = new Circle(radius);
    }
    public void SetHeight(double height)
    {
        _height = height;
    }


    public void SetCircle(Circle circle)
    {
    _circle = circle;
    }

    public double GetVolume()
    {
        double radius = _circle.GetRadius();
        return Math.PI * radius * radius * _height;
    }
}
