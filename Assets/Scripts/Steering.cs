using UnityEngine;

public static class Steering
{
    public static Vector2 wander(Vector2 velocity, float wanderStrength)
    {
        Vector2 previousDirection = velocity.normalized;

        Vector2 randomDirection = Random.insideUnitCircle.normalized;

        Vector2 direction = (previousDirection + randomDirection * wanderStrength).normalized;

        return direction;
    }

    public static Vector2 seek(Vector2 position, Vector2 target)
    {
        Vector2 direction = target - position;

        if (direction.sqrMagnitude > 0)
            direction.Normalize();

        return direction;
    }

    public static Vector2 flee(Vector2 position, Vector2 target)
    {
        return seek(position, target) * -1;
    }
}