using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed;
    public int DamageValue;
    void Update()
    {  
        transform.Translate(new Vector3(moveSpeed , 0, 0));
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 11)
        {
            collision.gameObject.GetComponent<EnemyController>().ReciveDamge(DamageValue);
            Destroy(this.gameObject);
        }
    }
}
