using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class itemCollector : MonoBehaviour
{  
   private int bananas = 0;
   [SerializeField] private AudioSource collectionSoundEffect;

   [SerializeField] private TMP_Text BananasText;
   private void OnTriggerEnter2D(Collider2D collision)
   {
       if (collision.gameObject.CompareTag("Banana")){
        collectionSoundEffect.Play();
         Destroy(collision.gameObject);
         bananas ++;
         BananasText.text = "Bananas: " + bananas;
       }
   }      
}
