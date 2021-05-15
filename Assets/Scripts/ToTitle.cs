using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToTitle : MonoBehaviour {

    public Image timeUp;
    public Image gameOver;
    private bool phase;

    void Start()
    {
        phase = false;
        timeUp.enabled = true;
        gameOver.enabled = false;
    }

    void Update () {
		if (Input.GetMouseButtonUp (0)) {
			StartCoroutine ("ChangePhase", 2f);
		}
        if (phase)
        {
            StartCoroutine("ShowTitleDelayed", 3f);
        }
    }
		IEnumerator ChangePhase(float delayTime) {
			// delayTime秒処理を停止
			yield return new WaitForSeconds(delayTime);
            timeUp.enabled = false;
            gameOver.enabled = true;
            phase = true;

		}

        IEnumerator ShowTitleDelayed(float delayTime)
        {
            // delayTime秒処理を停止
            yield return new WaitForSeconds(delayTime);
            Destroy(GameObject.Find("Canvas2"));
            SceneManager.LoadScene("Title");

        }

}