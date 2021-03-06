﻿using UnityEngine;
using System.Collections;

public class Easings : MonoBehaviour {
    
    public static float Linear(float t, float b, float c, float d)
    {
        return c * t / d + b;
    }
    public static float ExpoEaseOut(float t, float b, float c, float d)
    {
        return (t == d) ? b + c : c * (-Mathf.Pow(2, -10 * t / d) + 1) + b;
    }
    public static float ExpoEaseIn(float t, float b, float c, float d)
    {
        return (t == 0) ? b : c * Mathf.Pow(2, 10 * (t / d - 1)) + b;
    }
    public static float ExpoEaseInOut(float t, float b, float c, float d)
    {
        if (t == 0)
            return b;

        if (t == d)
            return b + c;

        if ((t /= d / 2) < 1)
            return c / 2 * Mathf.Pow(2, 10 * (t - 1)) + b;

        return c / 2 * (-Mathf.Pow(2, -10 * --t) + 2) + b;
    }
    public static float ExpoEaseOutIn(float t, float b, float c, float d)
    {
        if (t < d / 2)
            return ExpoEaseOut(t * 2, b, c / 2, d);

        return ExpoEaseIn((t * 2) - d, b + c / 2, c / 2, d);
    }
    public static float CircEaseOut(float t, float b, float c, float d)
    {
        return c * Mathf.Sqrt(1 - (t = t / d - 1) * t) + b;
    }
    public static float CircEaseIn(float t, float b, float c, float d)
    {
        return -c * (Mathf.Sqrt(1 - (t /= d) * t) - 1) + b;
    }
    public static float CircEaseInOut(float t, float b, float c, float d)
    {
        if ((t /= d / 2) < 1)
            return -c / 2 * (Mathf.Sqrt(1 - t * t) - 1) + b;

        return c / 2 * (Mathf.Sqrt(1 - (t -= 2) * t) + 1) + b;
    }
    public static float CircEaseOutIn(float t, float b, float c, float d)
    {
        if (t < d / 2)
            return CircEaseOut(t * 2, b, c / 2, d);

        return CircEaseIn((t * 2) - d, b + c / 2, c / 2, d);
    }
    public static float QuadEaseOut(float t, float b, float c, float d)
    {
        return -c * (t /= d) * (t - 2) + b;
    }
    public static float QuadEaseIn(float t, float b, float c, float d)
    {
        return c * (t /= d) * t + b;
    }
    public static float QuadEaseInOut(float t, float b, float c, float d)
    {
        if ((t /= d / 2) < 1)
            return c / 2 * t * t + b;

        return -c / 2 * ((--t) * (t - 2) - 1) + b;
    }
    public static float QuadEaseOutIn(float t, float b, float c, float d)
    {
        if (t < d / 2)
            return QuadEaseOut(t * 2, b, c / 2, d);

        return QuadEaseIn((t * 2) - d, b + c / 2, c / 2, d);
    }
    public static float SineEaseOut(float t, float b, float c, float d)
    {
        return c * Mathf.Sin(t / d * (Mathf.PI / 2)) + b;
    }
    public static float SineEaseIn(float t, float b, float c, float d)
    {
        return -c * Mathf.Cos(t / d * (Mathf.PI / 2)) + c + b;
    }
    public static float SineEaseInOut(float t, float b, float c, float d)
    {
        if ((t /= d / 2) < 1)
            return c / 2 * (Mathf.Sin(Mathf.PI * t / 2)) + b;

        return -c / 2 * (Mathf.Cos(Mathf.PI * --t / 2) - 2) + b;
    }
    public static float SineEaseOutIn(float t, float b, float c, float d)
    {
        if (t < d / 2)
            return SineEaseOut(t * 2, b, c / 2, d);

        return SineEaseIn((t * 2) - d, b + c / 2, c / 2, d);
    }
    public static float CubicEaseOut(float t, float b, float c, float d)
    {
        return c * ((t = t / d - 1) * t * t + 1) + b;
    }
    public static float CubicEaseIn(float t, float b, float c, float d)
    {
        return c * (t /= d) * t * t + b;
    }
    public static float CubicEaseInOut(float t, float b, float c, float d)
    {
        if ((t /= d / 2) < 1)
            return c / 2 * t * t * t + b;

        return c / 2 * ((t -= 2) * t * t + 2) + b;
    }
    public static float CubicEaseOutIn(float t, float b, float c, float d)
    {
        if (t < d / 2)
            return CubicEaseOut(t * 2, b, c / 2, d);

        return CubicEaseIn((t * 2) - d, b + c / 2, c / 2, d);
    }
    public static float QuartEaseOut(float t, float b, float c, float d)
    {
        return -c * ((t = t / d - 1) * t * t * t - 1) + b;
    }
    public static float QuartEaseIn(float t, float b, float c, float d)
    {
        return c * (t /= d) * t * t * t + b;
    }
    public static float QuartEaseInOut(float t, float b, float c, float d)
    {
        if ((t /= d / 2) < 1)
            return c / 2 * t * t * t * t + b;

        return -c / 2 * ((t -= 2) * t * t * t - 2) + b;
    }
    public static float QuartEaseOutIn(float t, float b, float c, float d)
    {
        if (t < d / 2)
            return QuartEaseOut(t * 2, b, c / 2, d);

        return QuartEaseIn((t * 2) - d, b + c / 2, c / 2, d);
    }
    public static float QuintEaseOut(float t, float b, float c, float d)
    {
        return c * ((t = t / d - 1) * t * t * t * t + 1) + b;
    }
    public static float QuintEaseIn(float t, float b, float c, float d)
    {
        return c * (t /= d) * t * t * t * t + b;
    }
    public static float QuintEaseInOut(float t, float b, float c, float d)
    {
        if ((t /= d / 2) < 1)
            return c / 2 * t * t * t * t * t + b;
        return c / 2 * ((t -= 2) * t * t * t * t + 2) + b;
    }
    public static float QuintEaseOutIn(float t, float b, float c, float d)
    {
        if (t < d / 2)
            return QuintEaseOut(t * 2, b, c / 2, d);
        return QuintEaseIn((t * 2) - d, b + c / 2, c / 2, d);
    }
    public static float ElasticEaseOut(float t, float b, float c, float d)
    {
        if ((t /= d) == 1)
            return b + c;

        float p = d * .3f;
        float s = p / 4;

        return (c * Mathf.Pow(2, -10 * t) * Mathf.Sin((t * d - s) * (2 * Mathf.PI) / p) + c + b);
    }
    public static float ElasticEaseIn(float t, float b, float c, float d)
    {
        if ((t /= d) == 1)
            return b + c;

        float p = d * .3f;
        float s = p / 4;

        return -(c * Mathf.Pow(2, 10 * (t -= 1)) * Mathf.Sin((t * d - s) * (2 * Mathf.PI) / p)) + b;
    }
    public static float ElasticEaseInOut(float t, float b, float c, float d)
    {
        if ((t /= d / 2) == 2)
            return b + c;

        float p = d * (.3f * 1.5f);
        float s = p / 4;

        if (t < 1)
            return -.5f * (c * Mathf.Pow(2, 10 * (t -= 1)) * Mathf.Sin((t * d - s) * (2 * Mathf.PI) / p)) + b;
        return c * Mathf.Pow(2, -10 * (t -= 1)) * Mathf.Sin((t * d - s) * (2 * Mathf.PI) / p) * .5f + c + b;
    }
    public static float ElasticEaseOutIn(float t, float b, float c, float d)
    {
        if (t < d / 2)
            return ElasticEaseOut(t * 2, b, c / 2, d);
        return ElasticEaseIn((t * 2) - d, b + c / 2, c / 2, d);
    }
    public static float BounceEaseOut(float t, float b, float c, float d)
    {
        if ((t /= d) < (1 / 2.75))
            return c * (7.5625f * t * t) + b;
        else if (t < (2 / 2.75))
            return c * (7.5625f * (t -= (1.5f / 2.75f)) * t + .75f) + b;
        else if (t < (2.5 / 2.75))
            return c * (7.5625f * (t -= (2.25f / 2.75f)) * t + .9375f) + b;
        else
            return c * (7.5625f * (t -= (2.625f / 2.75f)) * t + .984375f) + b;
    }
    public static float BounceEaseIn(float t, float b, float c, float d)
    {
        return c - BounceEaseOut(d - t, 0, c, d) + b;
    }
    public static float BounceEaseInOut(float t, float b, float c, float d)
    {
        if (t < d / 2)
            return BounceEaseIn(t * 2, 0, c, d) * .5f + b;
        else
            return BounceEaseOut(t * 2 - d, 0, c, d) * .5f + c * .5f + b;
    }
    public static float BounceEaseOutIn(float t, float b, float c, float d)
    {
        if (t < d / 2)
            return BounceEaseOut(t * 2, b, c / 2, d);
        return BounceEaseIn((t * 2) - d, b + c / 2, c / 2, d);
    }
    public static float BackEaseOut(float t, float b, float c, float d)
    {
        return c * ((t = t / d - 1) * t * ((1.70158f + 1) * t + 1.70158f) + 1) + b;
    }
    public static float BackEaseIn(float t, float b, float c, float d)
    {
        return c * (t /= d) * t * ((1.70158f + 1) * t - 1.70158f) + b;
    }
    public static float BackEaseInOut(float t, float b, float c, float d)
    {
        float s = 1.70158f;
        if ((t /= d / 2) < 1)
            return c / 2 * (t * t * (((s *= (1.525f)) + 1) * t - s)) + b;
        return c / 2 * ((t -= 2) * t * (((s *= (1.525f)) + 1) * t + s) + 2) + b;
    }
    public static float BackEaseOutIn(float t, float b, float c, float d)
    {
        if (t < d / 2)
            return BackEaseOut(t * 2, b, c / 2, d);
        return BackEaseIn((t * 2) - d, b + c / 2, c / 2, d);
    }
}
