using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    public TextMeshProUGUI InteractText;

    public void TextUpdate(string TextUpdate)
    {
        InteractText.SetText(TextUpdate);
    }
}
