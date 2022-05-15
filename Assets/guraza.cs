using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guraza : MonoBehaviour
{
    public int hp = 100;
    public int attack = 35;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire() {
       int MyWazaAttack = this.attack + 30;
        FindObjectOfType<Siroka>().KougekiUkeru(MyWazaAttack);
        

    }
    public void KougekiUkeru(int WazaAttack) {
        this.hp -= WazaAttack;
        FindObjectOfType<Hpbar>().Attack(hp);

    }
}
