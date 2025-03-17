using UnityEngine;

public class FloatingMovement : MonoBehaviour
{
    public float speed = 5f;

    private const float InputAcceleration = 4f;
    private Vector3 movementDirection;

    private void Update()
    {
        //GetKeys to bypass InputManager not set in package : 
        float hx = Input.GetKey(KeyCode.A) ? -1f : Input.GetKey(KeyCode.D) ? 1f : 0f;
        float hz = Input.GetKey(KeyCode.S) ? -1f : Input.GetKey(KeyCode.W) ? 1f : 0f;
        float v = Input.GetKey(KeyCode.Q) ? -1f : Input.GetKey(KeyCode.E) ? 1f : 0f;
        
        movementDirection = Vector3.MoveTowards(movementDirection, new Vector3(hx, v, hz), InputAcceleration * Time.deltaTime);
        transform.position += movementDirection * speed * Time.deltaTime;
    }
}