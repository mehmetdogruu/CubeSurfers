using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject target;
    public Vector3 distance;
    void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position + distance,Time.deltaTime);
    }
}
