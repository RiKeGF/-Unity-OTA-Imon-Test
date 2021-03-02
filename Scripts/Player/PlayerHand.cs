using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerHand : MonoBehaviour
{
   public Controller scController;
   public List<int> currencies;

   private bool inRobot;

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Tab) && inRobot)
      {
         if (scController.scHUD.hudShop.activeInHierarchy)
         {
            scController.scHUD.hudShop.SetActive(false);
            EventSystem.current.SetSelectedGameObject(null);
         }
         else
         {
            scController.scHUD.hudShop.SetActive(true);
            if (scController.scHUD.contentShop.transform.GetChild(0) != null)
            {
               EventSystem.current.SetSelectedGameObject(scController.scHUD.contentShop.transform.GetChild(0).gameObject);
            }
         
         }

      }
   }

   private void CollectCurrencie(Collider2D collision)
   {
      switch (collision.name)
      {
         case "Red_Currencie(Clone)":
         {
            if (Input.GetKeyDown(KeyCode.E))
            {
               int id = collision.GetComponent<IDCurrencie>().ID;
               currencies[id]++;
               scController.scHUD.textCountCurrencies[id].text = "x " + currencies[id];
               Destroy(collision.gameObject);
            }
            break;
         }
         case "Yellow_Currencie(Clone)":
         {
            if (Input.GetKeyDown(KeyCode.E))
            {
               int id = collision.GetComponent<IDCurrencie>().ID;
               currencies[id]++;
               scController.scHUD.textCountCurrencies[id].text = "x " + currencies[id];
               Destroy(collision.gameObject);
            }
            break;
         }
         case "Blue_Currencie(Clone)":
         {
            if (Input.GetKeyDown(KeyCode.E))
            {
               int id = collision.GetComponent<IDCurrencie>().ID;
               currencies[id]++;
               scController.scHUD.textCountCurrencies[id].text = "x " + currencies[id];
               Destroy(collision.gameObject);
            }
            break;
         }
         case "Green_Currencie(Clone)":
         {
            if (Input.GetKeyDown(KeyCode.E))
            {
               int id = collision.GetComponent<IDCurrencie>().ID;
               currencies[id]++;
               scController.scHUD.textCountCurrencies[id].text = "x " + currencies[id];
               Destroy(collision.gameObject);
            }
            break;
         }
         case "Grey_Currencie(Clone)":
         {
            if (Input.GetKeyDown(KeyCode.E))
            {
               int id = collision.GetComponent<IDCurrencie>().ID;
               currencies[id]++;
               scController.scHUD.textCountCurrencies[id].text = "x " + currencies[id];
               Destroy(collision.gameObject);
            }
            break;
         }
      }
   }

   private void OnTriggerEnter2D(Collider2D collision)
   {
      CollectCurrencie(collision);

      if (collision.CompareTag("Robot"))
      {
         inRobot = true;
      }
   }

   private void OnTriggerStay2D(Collider2D collision)
   {
      CollectCurrencie(collision);

      if (collision.CompareTag("Robot"))
      {
         inRobot = true;
      }
   }

   private void OnTriggerExit2D(Collider2D collision)
   {
      if (collision.CompareTag("Robot"))
      {
         inRobot = false;
      }
   }
}
