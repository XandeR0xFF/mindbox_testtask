using mindbox_testtask_lib;

namespace mindbox_testtask_tests;

[TestClass]
public class CircleTest
{
    [TestMethod]
    public void CalculateAreaTest()
    {
        IGeometryShape c = new Circle(10);
        Assert.AreEqual(c.Area, 314.16, 0.01);
    }
}