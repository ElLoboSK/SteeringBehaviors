using UnityEngine;

public class Coward : NonPlayerController
{
    public float fleeSpeed = 6f;
    public float fleeEnterDistance = 4f;
    public float fleeExitDistance = 10f;

    private bool fleeing = false;

    public override void handleMovement()
    {
        float distanceToTarget = Vector2.Distance(transform.position, target.position);

        if (distanceToTarget < fleeEnterDistance)
        {
            fleeing = true;
        }
        else if (distanceToTarget > fleeExitDistance)
        {
            fleeing = false;
        }

        if (fleeing)
        {
            rb.linearVelocity = Steering.flee(transform.position, target.position) * fleeSpeed;
        } else
        {
            rb.linearVelocity = Steering.wander(velocity, wanderStrength) * wanderSpeed;
        }

        velocity = rb.linearVelocity;
    }
}
