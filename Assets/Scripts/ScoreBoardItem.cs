using TMPro;
using Photon.Realtime;
using UnityEngine;

public class ScoreBoardItem : MonoBehaviour
{
    public TMP_Text deathsText;
    public TMP_Text killsText;
    public TMP_Text nameText;

    public void Initialize(Player player)
    {
        nameText.text = player.NickName;
    }

}
