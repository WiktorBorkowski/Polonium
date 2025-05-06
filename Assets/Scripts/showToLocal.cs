using Photon.Pun;
using UnityEngine;

public class showToLocal : MonoBehaviour
{
    public PhotonView PV;
    private void Awake()
    {
        gameObject.SetActive(PV.IsMine);
    }
}
