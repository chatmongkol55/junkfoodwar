using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
   
    public int Health;
    public int DamageValue;
    public float DamageCooldown;
    public float moveSpeed;
    private bool isStopped;
    void Update()
    {
        if (!isStopped)
        {
            transform.Translate(new Vector3(moveSpeed * -1, 0, 0));
        }
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.layer == 10)
        {
            StartCoroutine(Attack(collision));
            isStopped = true;
        }
        if (collision.gameObject.layer == 15)
        {
            isStopped = true;
        }
    }

    IEnumerator Attack(Collider2D collision)
    {
        if (collision == null)
        {
            isStopped = false;
        }
        else
        {
            collision.gameObject.GetComponent<PlantController>().ReciveDamge(DamageValue);
            yield return new WaitForSeconds(DamageCooldown);
            StartCoroutine(Attack(collision));
        }
        
    }

    public void ReciveDamge(int Damage)
    {
        if (Health - Damage <= 0)
        {
            transform.parent.GetComponent<SpawnPoint>().human.Remove(this.gameObject);
            Destroy(this.gameObject);
        }
        else
        {
            Health = Health - Damage;
        }
    }
}
