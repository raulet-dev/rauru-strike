using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Debri : MonoBehaviour
{

    private Vector3 targetPos;
    public GameObject explo;
    public GameObject sco;

    public float angle = 30F;
    public int score = 10;

    
    // Start is called before the first frame update
    void Start()
    {
        sco = GameObject.Find("Score");
        Transform target = GameObject.Find("Earth").transform;
        targetPos = target.position;
        transform.LookAt(target);
        transform.Rotate(new Vector3(0, 0, Random.Range(0, 360)), Space.World);
        StartCoroutine("SelfDestroy", 5f);

    }

        // Update is called once per frame
        void Update()
        {
            Vector3 axis = transform.TransformDirection(Vector3.up);
            transform.RotateAround(targetPos, axis, angle * Time.deltaTime);
        }
    void OnMouseDown()
    {
        sco.SendMessage("AddScore", score);
        Instantiate(explo, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    IEnumerator SelfDestroy(float delayTime)
    {
        // delayTime秒処理を停止
        yield return new WaitForSeconds(delayTime);
        Instantiate(explo, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }
}
