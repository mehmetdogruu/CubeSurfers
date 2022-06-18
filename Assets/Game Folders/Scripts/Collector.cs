using UnityEngine;

public class Collector : MonoBehaviour
{
    GameObject mainCube;
    int height;

    void Awake()
    {
        mainCube = GameObject.Find("Player");
    }

    void Update()
    {
        mainCube.gameObject.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z);
        this.gameObject.transform.localPosition = new Vector3(0, -height, 0);
    }
    public void HeightDown()
    {
        height--;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Collect" && other.gameObject.GetComponent<CollectableCube>().GetIsCollected()==false)
        {
            height++;
            other.gameObject.GetComponent<CollectableCube>().Collected();
            other.gameObject.GetComponent<CollectableCube>().SetIndex(height);
            other.gameObject.transform.parent = mainCube.transform;
        }
    }
}
