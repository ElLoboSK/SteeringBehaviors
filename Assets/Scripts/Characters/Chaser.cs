using UnityEngine;

public class Chaser : NonPlayerController
{
    public float chaseSpeed = 4f;
    public float chaseEnterDistance = 4f;
    public float chaseExitDistance = 8f;

    private bool chasing = false;

    public override void handleMovement()
    {
        float distanceToTarget = Vector2.Distance(transform.position, target.position);

        if (distanceToTarget < chaseEnterDistance)
        {
            chasing = true;
        }
        else if (distanceToTarget > chaseExitDistance)
        {
            chasing = false;
        }

        if (chasing)
        {
            rb.linearVelocity = Steering.seek(transform.position, target.position) * chaseSpeed;
        } else
        {
            rb.linearVelocity = Steering.wander(velocity, wanderStrength) * wanderSpeed;
        }

        velocity = rb.linearVelocity;
    }
}
