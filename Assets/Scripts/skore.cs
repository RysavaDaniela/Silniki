using UnityEngine;
using UnityEngine.UI;

public class skore : MonoBehaviour
{ 
    public Transform hrac;
    public Text skoreText;

    void Update()
    {
        skoreText.text = hrac.position.z.ToString("0");
    }
}
