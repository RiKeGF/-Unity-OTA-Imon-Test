using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
   public Controller scController;
   public List<Sprite> itens;
   public List<Sprite> currencies;
   public List<string> names;
   public int amount;
   public int currencieID;
   public int ID;

   public Text nameItem;
   public Image imgItem;
   public Image imgCurrencie;
   public Text amountItem;

   private void Start()
   {
      scController = GameObject.FindGameObjectWithTag("ScriptsController").GetComponent<Controller>();

      ID = Random.Range(0, itens.Count);

      nameItem.text = names[ID];
      imgItem.sprite = itens[ID];

      currencieID = Random.Range(0, currencies.Count);
      imgCurrencie.sprite = currencies[currencieID];

      int randomAmount = Random.Range(1, 10);
      amount = randomAmount;
      amountItem.text = amount + " x";

   }

   public void Select()
   {
      if (scController.scPlayerHand.currencies[currencieID] >= amount)
      {
         this.transform.SetParent(scController.scHUD.contentInventory.transform);
         scController.scPlayerHand.currencies[currencieID] -= amount;
         scController.scHUD.textCountCurrencies[currencieID].text = "x " + scController.scPlayerHand.currencies[currencieID];
         nameItem.enabled = false;
         imgCurrencie.enabled = false;
         amountItem.enabled = false;
         if (scController.scHUD.contentShop.transform.GetChild(0) != null)
         {
            EventSystem.current.SetSelectedGameObject(scController.scHUD.contentShop.transform.GetChild(0).gameObject);
         }
      }
   }
}
