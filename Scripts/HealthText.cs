using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
   [SerializeField] private Text text;
   [SerializeField] private Player player;

   private void Update()
   {
        text.text = "Health = " + player.Health;    
   }

}
