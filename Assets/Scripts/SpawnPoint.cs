using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{

    public GameObject debri;

    private float interval = 0.4F;

    private bool spawnStarted = false;

    void StartSpawn () {
      if (!spawnStarted) {
           spawnStarted = true;
           StartCoroutine("SpawnDebris"); 
       }
      }

      void StopSpawn () {
        if (spawnStarted) {
           spawnStarted = false;
           StopCoroutine("SpawnDebris");
        }
      }
  
              
    

  IEnumerator SpawnDebris() {
    while(true) {

      Instantiate(debri, transform.position, Quaternion.identity);
      
      yield return new WaitForSeconds(interval);
    }
    
   } 
      
}
