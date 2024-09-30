using mindbox_testtask_lib;

namespace mindbox_testtask_tests;

[TestClass]
public class TriangleTest
{
    [TestMethod]
    public void CalculateAreaTest()
    {
        IGeometryShape shape = new Triangle(5, 2, 6);
        Assert.AreEqual(shape.Area, 4.68, 0.01);

        IGeometryShape shape2 = new Triangle(5, 2, 7);
        Assert.AreEqual(shape2.Area, 0, 0.01);
    }

    [TestMethod]
    public void RightTriangle_IsTrue_Test()
    {
        Triangle t = new Triangle(6, 8, 10);
        Assert.IsTrue(t.IsRightAngled);
    }

    [TestMethod]
    public void RightTriangle_IsFalse_Test()
    {
        Triangle t = new Triangle(6, 8, 9);
        Assert.IsFalse(t.IsRightAngled);
    }
}
