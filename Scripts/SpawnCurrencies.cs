using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCurrencies : MonoBehaviour
{
   public Controller scController;
   public List<GameObject> currencies;
   private int currencieSpawn;
   private float delaySpawn = 2f;

   private void Update()
   {
      if (scController.scHUD.contentShop.transform.childCount > 0)
      {
         DelaySpawn();
      }
   }

   private void DelaySpawn()
   {
      delaySpawn -= Time.deltaTime;

      if (delaySpawn < 0)
      {
         SpawnRandomCurrencies();

         delaySpawn = Random.Range(2, 5);
      }
   }

   private void SpawnRandomCurrencies()
   {
      int random;
      do
      {
         random = Random.Range(0, currencies.Count);
      } while (random == currencieSpawn);

      currencieSpawn = random;

      Vector2 position = new Vector2(Random.Range(this.transform.position.x - 7, this.transform.position.x + 6), this.transform.position.y);
      Instantiate(currencies[random], position, Quaternion.identity);
   }
}
