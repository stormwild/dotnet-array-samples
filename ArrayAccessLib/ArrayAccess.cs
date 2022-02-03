// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace ArrayAccessLib;

public class ArrayAccess
{
    private readonly int[] _sampleArray = new int[] { 1, 2 };

    public int AccessNonExistingIndex()
    {
        return _sampleArray[2];
    }
}
