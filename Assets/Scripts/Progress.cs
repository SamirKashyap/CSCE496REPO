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
    public int flour = 1;
    public int sugar = 2;
    public int bakingSoda = 1;
    private int delay = 2;
    private bool already = false;
    public GameObject MixingBowl;
    public GameObject Cake;
    public GameObject ChoccyCake;
    public GameObject ZebraCake;
    public GameObject BigBoy;
    public Rigidbody rb;
    private GameObject cake;

  


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
        if (other.gameObject.CompareTag("Oven") && !already)
        {
            already = true;
            StartCoroutine(CookingCoroutine());
        }
    }

  
    void cooking()
    {
        Debug.Log("Cooking");
        //countText.text = "Ingredients: " + egg.ToString() + " eggs, " + milk.ToString() + " cups milk, " + bakingSoda.ToString() + " tablespoons bakingsoda, " + butter.ToString() + " sticks butter";
        Destroy(MixingBowl.gameObject);
        //int num = new System.Random().Next(1, 3);
        //switch (num)
        //{
        //    case 1:
        //        cake = (GameObject)Instantiate(Cake);
        //        cake.transform.position = new Vector3(-0.733f, 0.64f, -2.956f);
        //        cake.transform.localScale = new Vector3(0.4f, 0.05f, 0.4f);
        //        break;
        //    case 2:
        //        cake = (GameObject)Instantiate(ZebraCake);
        //        cake.transform.position = new Vector3(-0.981f, 0.303f, -3.962f);
        //        cake.transform.localScale = new Vector3(0.07867207f, 0.07867207f, 0.07867207f);
        //        break;
        //    case 3:
        //        cake = (GameObject)Instantiate(BigBoy);
        //        cake.transform.position = new Vector3(0.405f, 1.143f, -2.055f);
        //        cake.transform.localScale = new Vector3(1f, 0.8f, 1f);
        //        break;
        //}
        cake = (GameObject)Instantiate(Cake);
        cake.transform.position = new Vector3(-0.733f, 0.64f, -2.956f);
        cake.transform.localScale = new Vector3(0.4f, 0.05f, 0.4f);
        rb = cake.GetComponent<Rigidbody>();
        rb.isKinematic = false;
    }

}
