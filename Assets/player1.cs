using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class player1 : MonoBehaviour {

    public string character;

        // Start is called before the first frame update
        void Start() {
            character = FindObjectOfType<kantoku>().player1Name;
            GetComponent<Image>().sprite = Resources.Load<Sprite>(character);
        }

        // Update is called once per frame
        void Update() {
            
        }
    }

