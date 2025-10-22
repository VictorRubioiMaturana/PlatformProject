using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Magnet : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        MagneticObjects mag = collision.GetComponent<MagneticObjects>();
        if (collision.gameObject.CompareTag("MagneticObjects") && Input.GetKey(KeyCode.M))
        {
            mag.SetTarget(transform.parent.position);
        }
        else
        {
            mag.NoTarget();
        }
    }
}
