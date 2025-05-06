using UnityEngine;

public class SbToggle : MonoBehaviour
{
    void Update()
    {
        transform.GetChild(0).gameObject.SetActive(Input.GetKey(KeyCode.Tab));
    }
}
