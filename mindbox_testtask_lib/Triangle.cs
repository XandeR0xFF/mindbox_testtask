namespace mindbox_testtask_lib;

public class Triangle : IGeometryShape
{
    private int _a;
    private int _b;
    private int _c;

    private double _area;
    private bool _isRightAngled;

    public Triangle(int a, int b, int c)
    {
        if (a <= 0)
            throw new ArgumentException(nameof(a), Properties.Resources.TriangleSideLessOrEqualZerroMessage);
        if (b <= 0)
            throw new ArgumentException(nameof(b), Properties.Resources.TriangleSideLessOrEqualZerroMessage);
        if (c <= 0)
            throw new ArgumentException(nameof(c), Properties.Resources.TriangleSideLessOrEqualZerroMessage);

        if (a > b + c)
            throw new ArgumentException(nameof(a), Properties.Resources.TriangleSideMoreThenSumOtherSideMessage);
        if (b > a + c)
            throw new ArgumentException(nameof(b), Properties.Resources.TriangleSideMoreThenSumOtherSideMessage);
        if (c > a + b)
            throw new ArgumentException(nameof(c), Properties.Resources.TriangleSideMoreThenSumOtherSideMessage);

        _a = a;
        _b = b;
        _c = c;

        CalculateArea();
        RightAngledCheck();
    }

    public int A => _a;
    public int B => _b;
    public int C => _c;

    public bool IsRightAngled => _isRightAngled;

    #region IGeometryShape
    public double Area => _area;
    #endregion

    private void CalculateArea()
    {
        double sp = (_a + _b + _c) / 2.0;                           // Semi-perimeter
        _area = Math.Sqrt(sp * (sp - _a) * (sp - _b) * (sp - _c));  // Heron's Formula
    }

    private void RightAngledCheck()
    {
        int hypotenuse = 0;
        int legA = 0;
        int legB = 0;

        if (A > B && (A > C))
        {
            hypotenuse = A;
            legA = C;
            legB = B;
        }
        else if (B > A && B > C)
        {
            hypotenuse = B;
            legA = A;
            legB = C;
        }
        else
        {
            hypotenuse = C;
            legA = A;
            legB = B;
        }

        _isRightAngled = hypotenuse * hypotenuse == legA * legA + legB * legB;
    }
}
