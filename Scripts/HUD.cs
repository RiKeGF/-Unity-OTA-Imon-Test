using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HUD : MonoBehaviour
{
   public List<Text> textCountCurrencies;
   public GameObject hudShop;
   public GameObject contentShop;
   public GameObject contentInventory;
   public GameObject item;

   private void Awake()
   {
      Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;

      for (int i = 0; i < Random.Range(3, 6); i++)
      {
         GameObject itemShop = Instantiate(item, item.transform.position, Quaternion.identity);
         itemShop.transform.SetParent(contentShop.transform);
         itemShop.transform.localScale = new Vector2(1, 1);
      }
      hudShop.SetActive(false);
   }

   private void Update()
   {
      if (hudShop.activeInHierarchy)
      {
         Time.timeScale = 0;
      }
      else
      {
         Time.timeScale = 1;
      }

   }


}
