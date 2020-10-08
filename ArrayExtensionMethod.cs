using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ArrayExtensionMethod
{
    public static List<int> RemoveAllSpecifiedIndicesFromArray(this int[] a, bool[] indicesToRemove)
    {
        List<int> b = new List<int>();
        for (int i = 0; i < indicesToRemove.Length; ++i)
        {
            if (!indicesToRemove[i])
                b.Add(a[i]);
        }

        return b;
    }
    public static List<int> IndexOf(this Array a, object o)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < a.Length; ++i)
        {
            if (a.GetValue(i).Equals(o))
            {
                result.Add(i);
            }
        }
        result.Sort();
        return result;
    }
}
