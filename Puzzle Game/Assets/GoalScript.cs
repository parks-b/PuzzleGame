using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoalScript : MonoBehaviour
{


    public GameManager gm;
    // Start is called before the first frame update


    public void Start(){
        gm = GameObject.Find("Canvas").GetComponent<GameManager>();
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision was with an object tagged "wall"
        if (collision.gameObject.CompareTag("red"))
        {
            Debug.Log("trigger");
            // Add points and switch scenes
            gm.AddPoints(100);

            if (SceneManager.GetActiveScene().name == "SampleScene"){
                SceneManager.LoadScene("Scene2");
            }
            else if (SceneManager.GetActiveScene().name == "Scene2"){
                SceneManager.LoadScene("Scene3");
            }
            else if (SceneManager.GetActiveScene().name == "Scene3"){
                SceneManager.LoadScene("SampleScene");
            }

            
        }
    }
}
