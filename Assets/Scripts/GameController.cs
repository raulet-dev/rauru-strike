using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    
    private GameObject spawnPoint;
    private GameObject score;
    private Timer timer;
    //public Image timeUp;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = GameObject.Find("SpawnPoint");
        score = GameObject.Find("Score");
        timer = GameObject.Find("Timer").GetComponent<Timer>();
        //timeUp.enabled = false;
        score.SendMessage("InitScore");

    }

    // Update is called once per frame
    void Update() {
  
           timer.StartTimer();
           spawnPoint.SendMessage("StartSpawn");
           
           
    if (timer.GetTimeRemaining() == 0){
          spawnPoint.SendMessage("StopSpawn");
          timer.StopTimer();
          DestroyAllDebris();
            //timeUp.enabled = true;
            Destroy(GameObject.Find("Timer"));
          SceneManager.LoadScene("GameOver");

        }
    }

    void DestroyAllDebris() {
    GameObject[] debris = GameObject.FindGameObjectsWithTag("debri");
    foreach (GameObject debri in debris) {
    Destroy(debri);
    }
    }

}
