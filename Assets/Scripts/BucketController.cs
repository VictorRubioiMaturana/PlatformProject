using UnityEngine;
public class BucketController : MonoBehaviour
{
    Animator bucketAnimator; //Animator to control bucket animations.
    BoxCollider2D triggerCollider; //Collider used as trigger to detect player.

    void Start()
    {
        bucketAnimator = GetComponent<Animator>(); //Get the Animator component from the bucket.
        triggerCollider = GetComponent<BoxCollider2D>(); //Get the BoxCollider2D component.
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) //If the player enters the trigger
        {
            triggerCollider.enabled = false; //Disable the trigger to avoid multiple activations.
            bucketAnimator.SetBool("IsFalling", true); //Set the animation bool to make the bucket fall.
        }
    }
}
