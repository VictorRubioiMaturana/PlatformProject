using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    private Camera mainCamera; //Reference to the main camera.
    private Vector3 cursosPosition; //Position where the player will shoot or aim.
    [SerializeField] GameObject pointer; //Pointer object to show the direction.

    void Start()
    {
        mainCamera = Camera.main; //Get the main camera from the scene.
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //If left mouse button is pressed
        {
            cursosPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition); //Get the mouse position in world coordinates.
            cursosPosition.z = transform.position.z; //Keep the z position same as player.
        }
        pointer.transform.position = Vector3.MoveTowards(pointer.transform.position, cursosPosition, 100f); //Move the pointer to the target position.
    }
}