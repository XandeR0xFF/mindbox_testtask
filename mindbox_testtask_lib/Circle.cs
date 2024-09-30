namespace mindbox_testtask_lib;

public class Circle : IGeometryShape
{
    private int _radius;
    private double _area;

    public Circle(int radius)
    {
        _radius = radius;
        _area = Math.PI * Math.Pow(Radius, 2);
    }

    public int Radius => _radius;

    #region IGeometryShape
    public double Area => _area;
    #endregion

}
