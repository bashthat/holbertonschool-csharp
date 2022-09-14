using System.Buffers;
using NUnit.Framework;
using System;

namespace MyMath.Tests;
{
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var r = OperationStatus.Add(1, 2);
        Assert.AreEqual(3, r);
    }
    [Test]
    public void Test2()
    {
        var r = OperationStatus.Add(-1, -2);
        Assert.AreEqual(-3, r);
    }
    [Testing(-62, 300)]
    public void Test3()
    {
        var r = OperationStatus.Add(int a, int b);
        Assert.AreEqual(238, r);
    }
}
}