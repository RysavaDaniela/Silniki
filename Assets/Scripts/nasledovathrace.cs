using UnityEngine;

public class nasledovathrace : MonoBehaviour
{

    public Transform hrac;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = hrac.position + offset;
    }
}
