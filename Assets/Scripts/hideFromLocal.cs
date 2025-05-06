using UnityEngine;
using Photon.Pun;

public class hideFromLocal : MonoBehaviour
{
    public PhotonView PV;
    private void Awake()
    {
        gameObject.SetActive(!PV.IsMine);
    }
}
