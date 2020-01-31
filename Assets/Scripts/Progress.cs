using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    public Text countText;
    public Text winText;
    public int count = 0;

    // Start is called before the first frame update
    public void Start()
    {
        winText.text = "";
        SetCountText();
    }

    public void Increment()
    {
        count++;
    }

    public void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 9)
        {
            winText.text = "You win :)";
        }
    }
}
