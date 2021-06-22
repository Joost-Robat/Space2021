using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overheating : MonoBehaviour
{
     int shot, check, value, overheat, minHeat, maxHeat, decVal, incVal;
     bool heating;
     void Update()
     {
         if (shot == check)//here
         {
             //shooting code here
             overheat += incVal; //increment heat
             heating = true; //heat check
         }
 
         //heat clamps
         if (overheat >= maxHeat)
         {
             overheat = maxHeat;
             heating = false;
         }
         else if (overheat <= minHeat)
         {
             overheat = minHeat;
             heating = true;
         }
 
 
         //now here we decrement
         if (heating)
         {
             StartCoroutine("decHeat");
         }
     }
 
     IEnumerator decHeat()
     {
         //wait for 1 sec
         yield return new WaitForSeconds(1);
         overheat -= decVal;// decrease the value from overheat
         
     }
 }
