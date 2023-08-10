using Superhero003.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Superheroes003.Test;

/// <summary>
/// Xunit what is it?
/// lib - ??
/// note note
/// </summary>
public class MathTest
{
    [Fact]
    public void additionIsTrue()
    {
        // Arrange - assign variables / objects etc.
        int t1 = 2;
        int t2 = 2;
        int sum = t1 + t2;

        string s = new string("omg");
        Math2 obj = new Math2();
        // Act - Invoke methods
        var result = obj.add(t1, t2);
        // Assert - verify we got the right result
        Assert.Equal(sum, result);
    }

    [Fact]
    public void additionIsNotValid()
    {
        // Arrange - assign variables / objects etc.
        int t1 = 3;
        int t2 = 2;
        int sum = t1 + t2;
        Math2 obj = new Math2();
        // Act - Invoke methods
        var result = obj.add(t1, t2);
        // Assert - verify we got the right result
        Assert.Equal(52, result);
    }

    // Arrange
    // Act
    // Assert
}
