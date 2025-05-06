using UnityEngine;
using UnityEngine.UI;

public class AmmoBar : MonoBehaviour
{   
    public Image fill;
    public Text text;
    private float amount;

    private void Update()
    {
        //amount = selectedGun.ammo;
       // fill.fillAmount = amount / selectedGun.gunCapacity;
        text.text = amount.ToString();
    }
}


