using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kantoku : MonoBehaviour
{
    public int player1Hp = 1;
    public string player1Name = "";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Character(string name) {
        if(name == "guraza") {
            player1Hp = 100;
            player1Name = name;
        }
        if (name == "dorasu") {
            player1Hp = 150;
            player1Name = name;
            
        }
    }

    void Awake() {
        DontDestroyOnLoad(gameObject);
    }
}
