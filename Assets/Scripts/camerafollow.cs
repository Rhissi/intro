using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public GameObject objectToFollow;
    public Vector3 offset;


    void Update()
    {
        transform.position = objectToFollow.transform.position + offset; 
    }
}
