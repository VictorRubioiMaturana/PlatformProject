using UnityEngine;

public class BucketController : MonoBehaviour
{
    Animator bucketAnimator;
    BoxCollider2D triggerCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bucketAnimator = GetComponent<Animator>();
        triggerCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            triggerCollider.enabled = false;
            bucketAnimator.SetBool("IsFalling", true);
        }
    }
}
