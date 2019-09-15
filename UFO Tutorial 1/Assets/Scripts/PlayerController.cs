using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour {
    public float speed;
    public Text countText;
    public Text winText;


    private Rigidbody2D rd2d;
    private int count;

    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
        count = 0;
        winText.text = "";
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
            winText.text = "You win! Game created by Randall Forehand!";

    }
    void FixedUpdate()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
    rd2d.AddForce(movement * speed);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            countText.text = "Count: " + count.ToString();
            if (count >= 12)
                winText.text = "You win! Game created by Randall Forehand!";
        }
        void SetCountText()
        {
            
        }
    }
}
