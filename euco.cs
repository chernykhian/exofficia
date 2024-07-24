public static float EaseOut(float t)
{
    return t / (1 - t) * (1 - Mathf.Exp(-t));
}
