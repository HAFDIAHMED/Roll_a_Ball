using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    private int count = 0;

    public float speed;
    public Text countText;
    public Text winText;
   //Before generating the frame
   /*
   void Update()
    {

    }
    */

    void Start ()
    {
     rb = GetComponent<Rigidbody>();
     countText.text = "Count : " + count.ToString();
     winText.text = "";
    }

    //Before performing physics calculation
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal , 0 , moveVertical);
        //rb.AddForce(moveHorizontal , 0 , moveVertical, ForceMode.Impulse);
        rb.AddForce(movement * speed);
    }

     IEnumerator OnTriggerEnter(Collider other)  
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive (false);
            count++;
            countText.text = "Count : " + count.ToString();
            if(count >= 12)
            {
                winText.text = "You win !!";
                yield return new WaitForSeconds(4);
                SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
            }
        }
    }

}
 