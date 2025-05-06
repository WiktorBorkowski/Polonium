using UnityEngine;
using TMPro;
using Photon.Pun;

public class PlayerNameManager : MonoBehaviour
{
    [SerializeField] TMP_InputField nameInput;

    private void Start()
    {
        if (PlayerPrefs.HasKey("username"))
        {
            nameInput.text = PlayerPrefs.GetString("username");
            PhotonNetwork.NickName = PlayerPrefs.GetString("username");
        }
        else
        {
            nameInput.text = "Guest User " + Random.Range(0, 9999).ToString("0000");
            onNameValueChanged();
        }
    }

    public void onNameValueChanged()
    {
        PhotonNetwork.NickName = nameInput.text;
        PlayerPrefs.SetString("username", nameInput.text);
    }
}
