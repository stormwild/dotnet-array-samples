// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using ArrayAccessLib;
using Xunit;
using Xunit.Abstractions;

namespace ArrayAccessLibTests;

public class ArrayAccessTests
{
    private readonly ITestOutputHelper _output;

    public ArrayAccessTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void TestArrayAccessOutofBounds()
    {
        // Arrange
        var sut = new ArrayAccess();

        // Act
        // var result = sut.AccessNonExistingIndex();

        // Assert
        var ex = Assert.Throws<InvalidOperationException>(() => sut.AccessNonExistingIndex());

        _output.WriteLine($"Exception: {ex.Message}");
    }
}
