using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    public Text countText;
    public Text winText;
    public int egg = 4;
    public int milk = 1;
    public int salt = 1;
    public int butter = 2;
    public int flour = 2;
    public int sugar = 2;
    public int bakingSoda = 1;

    // Start is called before the first frame update
    public void Start()
    {
        winText.text = "";
        //SetCountText();
    }

    public void Increment(string type)
    {
        switch (type)
        {
            case "Egg":
                egg--;
                Debug.Log("Egg");
                break;
            case "Milk":
                milk--;
                Debug.Log("Milk");
                break;
            case "BakingSoda":
                bakingSoda--;
                Debug.Log("BakingSoda");
                break;
            case "Butter":
                butter--;
                Debug.Log("Butter");
                break;
            case "Sugar":
                sugar--;
                Debug.Log("Sugar");
                break;
            case "Salt":
                salt--;
                Debug.Log("Salt");
                break;
            case "Flour":
                flour--;
                Debug.Log("Flour");
                break;
            default:
                break;
        }
    }

    //public void SetCountText()
    //{
    //    countText.text = "Count: " + count.ToString();
    //    if (count >= 9)
    //    {
    //        winText.text = "You win :)";
    //    }
    //}
}
