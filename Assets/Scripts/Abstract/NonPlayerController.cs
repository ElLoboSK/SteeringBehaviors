using UnityEngine;

public abstract class NonPlayerController : MonoBehaviour
{
    //Settings
    public Transform target;
    public float wanderSpeed = 2f;
    public float wanderStrength = 0.05f;

    //Internal references
    protected Rigidbody2D rb;

    //Variables
    protected Vector2 velocity = Vector2.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        handleMovement();
    }

    public virtual void handleMovement()
    {
        
    }
}
