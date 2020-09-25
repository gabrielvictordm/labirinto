using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentar : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Debug.Log(h);
        transform.Translate(h * speed * Time.deltaTime, 0, v* speed * Time.deltaTime);
    }
}
