using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSound : MonoBehaviour
{
  public void OnPlay() 
  {
       GetComponent<AudioSource>().Play();
  }
   
}