using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

public void Start(){
    DontDestroyOnLoad(this.gameObject);
}

   
    public static GameManager Instance; // Static instance of the GameManager class
    public int totalPoints = 0; // The total number of points the player has

 
    public void AddPoints(int pointsToAdd)
    {
        totalPoints += pointsToAdd;
        scoreText.text = totalPoints.ToString();
    }




}

