using UnityEngine;

public class CollectableCube : MonoBehaviour
{
    bool isCollected;
    int index;
    public Collector collector;

    void Update()
    {
        if (transform.parent!=null)
        {
            if (isCollected)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }
    public bool GetIsCollected()
    {
        return isCollected;
    }
    public void Collected()
    {
        isCollected = true;
    }
    public void SetIndex( int index)
    {
        this.index = index;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Obstacle")
        {
            collector.HeightDown();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
