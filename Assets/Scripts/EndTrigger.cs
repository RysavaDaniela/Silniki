using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public HerniManazer herniManazer;

    void OnTriggerEnter ()
    {
        herniManazer.CompleteLevel();

    }


}
