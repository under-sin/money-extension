namespace MoneyExtension.test;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal amount = 298.99M;
        var cents = amount.ToCents();

        Assert.AreEqual(29899, cents);
    }
}