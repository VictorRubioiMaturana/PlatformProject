using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 cursosPosition;
    [SerializeField] GameObject pointer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cursosPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            cursosPosition.z = transform.position.z;
        }
        pointer.transform.position = Vector3.MoveTowards(pointer.transform.position, cursosPosition, 100f);
    }
}
