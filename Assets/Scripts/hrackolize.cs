using UnityEngine;

public class hrackolize : MonoBehaviour {

    public pohybhrace movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "prekazka")
        {
            movement.enabled = false;
            FindObjectOfType<HerniManazer>().EndGame();
        }




    }

}
