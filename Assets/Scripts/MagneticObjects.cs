using UnityEngine;
using UnityEngine.UIElements;

public class MagneticObjects : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    Rigidbody2D rb;

    bool hasTarget;
    Vector3 targetPosition;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (hasTarget)
        {
            Vector2 targetDirection = (targetPosition - transform.position).normalized;
            rb.linearVelocity = new Vector2(targetDirection.x, targetDirection.y) * speed;
        }
    }

    public void SetTarget(Vector3 position)
    {
        targetPosition = position;
        hasTarget = true;
    }

    public void NoTarget()
    {
        hasTarget = false;
    }

}
