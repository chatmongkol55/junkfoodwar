using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantController : MonoBehaviour
{
    public int Health;
    public GameObject bullet;
    public List<GameObject> human;
    public float attackCooldown;
    private float attackTime;
    public int DamageValue;
    public bool isAttacking;

    private void Update()
    {
        if (human.Count > 0 && isAttacking == false)
        {
            isAttacking = true;
        }
        else if (human.Count == 0 && isAttacking == true)
        {
            isAttacking = false;
        }

        if (isAttacking)
        {
            if (attackTime <= Time.time)
            {
                GameObject bulletInstance = Instantiate(bullet, transform);
                bulletInstance.GetComponent<Bullet>().DamageValue = DamageValue;
                attackTime = Time.time + attackCooldown;
            }
        }
    }

    public void ReciveDamge(int Damage)
    {
        if (Health - Damage <= 0)
        {      
            Destroy(this.gameObject);
        }
        else
        {
            Health = Health - Damage;
        }
    }
}
