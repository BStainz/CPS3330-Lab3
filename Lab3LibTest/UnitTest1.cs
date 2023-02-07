using Xunit;
using Lab3Lib;
namespace Lab3Lib;
//Brendan Hannon CPS 3330 SPRING 2023 LAB #3
public class UnitTest1
{
    [Fact]
    public void TestMinOf2One()
    {
        int a = 2;
        int b = 4; 
        int expected = 2; 

        int actual = Lab3Lib.Min.MinOf2(a,b);

        Assert.Equal(expected, actual);

    }
    [Fact]
    public void TestMinof2Two()
    {
        int a = 88;
        int b = 9;
        int expected = 9;

        int actual = Lab3Lib.Min.MinOf2(a,b);
        
        Assert.Equal(expected, actual);

    }
        [Fact]
    public void TestMinOf3One()
    {
        int a = 22;
        int b = 77;
        int c = 45;
        int expected = 22;

        int actual = Lab3Lib.Min.MinOf3(a,b,c);

        Assert.Equal(expected,actual);

    }
    [Fact]
    public void TestMinOf3Two()
    {
        int a = 77;
        int b = 11;
        int c = 40;
        int expected = 11;

        int actual = Lab3Lib.Min.MinOf3(a,b,c);

        Assert.Equal(expected,actual);
        
    }
    [Fact]
    public void TestMinOf3Three()
    {
        int a = 30;
        int b = 9;
        int c = 1;
        int expected = 1;
//Brendan Hannon CPS 3330 SPRING 2023 LAB #3
        int actual = Lab3Lib.Min.MinOf3(a,b,c);

        Assert.Equal(expected,actual);
    }
}