using UnityEngine;

public static class Extensions
{
    /// <summary>
    /// Gets the angle to the provided point.
    /// </summary>
    /// <param name="vector">Starting point</param>
    /// <param name="destination">Destination point</param>
    public static float AngleToPoint(this Vector2 vector, Vector2 destination)
    {
        Vector2 lookDirection = destination - vector;
        float rotZ = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        return rotZ;
    }
}