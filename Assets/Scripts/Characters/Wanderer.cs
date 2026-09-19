using UnityEngine;

public class Wanderer : NonPlayerController
{
    public override void handleMovement()
    {
        rb.linearVelocity = Steering.wander(velocity, wanderStrength) * wanderSpeed;
        velocity = rb.linearVelocity;
    }
}
