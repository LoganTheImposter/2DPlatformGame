using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private AudioSource finishSound;

    private bool levelComplete = false;
    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }
     
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" && !levelComplete){
            finishSound.Play();
            levelComplete = true;
            Invoke("CompleteLevel", 2f);            
        }
    }

    private void CompleteLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
