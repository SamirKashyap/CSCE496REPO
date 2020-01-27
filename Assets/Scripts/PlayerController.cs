using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Valve.VR.InteractionSystem
{
    public class PlayerController : MonoBehaviour
    {
        public float speed;
        public Text countText;
        public Text winText;

        private Rigidbody rb;
        public int count;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            count = 0;
            //winText.text = "";
            SetCountText();
        }

        public void CountUp()
        {
            count += 1;
            SetCountText();
        }

        public void SetCountText()
        {
            countText.text = "Count: " + count.ToString();
            if (count >= 9)
            {
               winText.text = "You win :)";
            }
        }

        void FixedUpdate()
        {
            //    float moveHorizontal = Input.GetAxis ("Horizontal");
            //    float moveVertical = Input.GetAxis ("Vertical");

            //    Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

            //    rb.AddForce (movement * speed);
        }

        //void OnTriggerEnter(Collider other)
        //{
        //    if (other.gameObject.CompareTag("Pick Up"))
        //    {
        //        other.gameObject.SetActive(false);
        //        count += 1;
        //        SetCountText();
        //    }
        //}
    }
}
