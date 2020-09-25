using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class colisaolab : MonoBehaviour
{
    public string fase;
    void OnCollisionEnter(Collision outro){
        SceneManager.LoadScene(fase);
    }
}
