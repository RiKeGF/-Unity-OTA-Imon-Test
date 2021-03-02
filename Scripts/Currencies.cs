using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currencies : MonoBehaviour
{

    void Start()
    {
      StartCoroutine(DestroyCurrencie());
    }

   IEnumerator DestroyCurrencie()
   {
      while (true)
      {
         yield return new WaitForSeconds(5f);
         break;
      }
      Destroy(this.gameObject);
   }
}
