using System;
using UnityEngine;

public static class Extensions
{
    public static void IfNotNull<T>(this T component, Action<T> action) where T : Component
    {
        if (!component)
            return;
        action?.Invoke(component);
    }

    public static void IfTrue(bool condition, Action action)
    {
        if (condition)
            action?.Invoke();
    }
    public static void IfFalse(bool condition, Action action)
    {
        if (!condition)
            action?.Invoke();
    }
}

