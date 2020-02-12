using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

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
    private int delay = 8;

    // Start is called before the first frame update
    public void Start()
    {
        winText.text = "";
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
                sugar-=2;
                Debug.Log("Sugar");
                break;
            case "Salt":
                salt--;
                Debug.Log("Salt");
                break;
            case "Flour":
                flour-=2;
                Debug.Log("Flour");
                break;
            default:
                break;
        }
    }

    IEnumerator CookingCoroutine()
    {
        yield return new WaitForSeconds(delay);
        cooking();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Oven"))
        {
            StartCoroutine(CookingCoroutine());
            
        }
    }

  
    void cooking()
    {
        Debug.Log("Cooking");
        countText.text = "Ingredients: " + egg.ToString() + " eggs, " + milk.ToString() + " cups milk, " + bakingSoda.ToString() + " tablespoons bakingsoda, " + butter.ToString() + " sticks butter";
    }

}
