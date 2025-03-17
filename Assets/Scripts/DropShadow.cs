using UnityEngine;

public class DropShadow : MonoBehaviour
{
    public GameObject baseObject;
    public float GroundY = 0f;
    public bool DrawLine = false;
    void Update()
    {
        Vector3 targetPos = baseObject.transform.position;
        targetPos.y = 0f;
        transform.position = targetPos; 

        if (DrawLine)
        {
            Debug.DrawLine(baseObject.transform.position, transform.position, Color.black);
        }
    }
}
