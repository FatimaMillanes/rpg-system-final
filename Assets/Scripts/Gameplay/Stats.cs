using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public float attackDmg;
    public float attackSpeed;
    public float attackTime;
    //float damage = -10f;
    //float health = 100;
    private Animator animation;

    public Animator Animation { get => animation; set => animation = value; }

    //HeroCombat heroCombatScript;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        
        //heroCombatScript = GameObject.FindGameObjectWithTag("Player").GetComponent<HeroCombat>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //AdjustCurrentHealth();
        //if(health<=0)
        {
            //Destroy(gameObject);
            //heroCombatScript.targetedEnemy=null;
            //heroCombatScript.performMeleeAtack = false;
        }
    }
    public void TakeDamage(int amount)
    {
        //currentHealth -= amount;
        //if(currentHealth<=0){
            //enemy dead
            //back to other scene
            //anim.SetBool(¨ded¨)
            //Animation.SetBool("isDead", true);
            
        //}
    }
    
    //public float AdjustCurrentHealth()
    /*{
        if (Input.GetMouseButtonDown(0))
            {

                
            }return (currentHealth);
    }*/
}
