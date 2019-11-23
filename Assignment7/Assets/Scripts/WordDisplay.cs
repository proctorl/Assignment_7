using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordDisplay : MonoBehaviour
{

    public Text text;
    public float fallSpeed = 1f;
    public GameObject wordBody;
    public Rigidbody rb;
    public static bool hitFloor = false;
    private float timer = 0f;
    public int thrust = 1;
    public static int typedScore = 0;
    public static int lostScore = 0;
    public int textColor = DropdownValue.myIndex;

    
    public void SetWord(string word)
    {
        text.text = word;

        Debug.Log(textColor);
        if (DropdownValue.myIndex == 1)
            text.color = Color.white;
        if (DropdownValue.myIndex == 2)
            text.color = Color.white;
        if (DropdownValue.myIndex == 3)
            text.color = Color.yellow;
        if (DropdownValue.myIndex == 4)
            text.color = Color.green;
    }



    public void RemoveLetter(int index)
    {
        text.text = text.text.Remove(0,1);

        text.color = Color.red;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
        typedScore++;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "floor" )
            lostScore++;
        hitFloor = true;
    }
    private void Update()
    {
        thrust = Random.Range(10, 30);
        if (lostScore == 5)
            SceneManager.LoadScene("Exit");
       
        if (transform.position.y <= 2 && transform.position.z < 589.3)
        {
          
            rb.useGravity = true;
            rb.isKinematic = false;
            rb.AddForce(transform.forward * thrust);
            

        }
        else
        {
            transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
        }
        if (transform.position.y <= 2 && transform.position.z == 592)
            lostScore++;



    }

    
}