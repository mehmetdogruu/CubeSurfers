using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float forwardVelocity;
    [SerializeField]
    float horizontalVelocity;


    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal")*horizontalVelocity*Time.deltaTime;
        this.transform.Translate(horizontalAxis,-.5f, forwardVelocity * Time.deltaTime);
    }
}
