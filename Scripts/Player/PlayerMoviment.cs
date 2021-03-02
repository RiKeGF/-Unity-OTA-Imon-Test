using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
   private Rigidbody2D rb;

   [SerializeField] private float move;
   [SerializeField] private float moveSpeed = 4f;

   // Start is called before the first frame update
   void Start()
   {
      rb = this.GetComponent<Rigidbody2D>();
   }

   // Update is called once per frame
   void Update()
   {

   }

   private void FixedUpdate()
   {

      Moviment();


   }

   private void Moviment()
   {
      move = Input.GetAxis("Horizontal");

      rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);

      if (move < 0)
      {
         this.transform.localScale = new Vector2(-0.7f, 0.7f);
      }
      else if (move > 0)
      {
         this.transform.localScale = new Vector2(0.7f, 0.7f);
      }
   }
}
