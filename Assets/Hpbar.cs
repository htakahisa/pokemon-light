using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI�g���Ƃ��͖Y�ꂸ�ɁB
using UnityEngine.UI;

public class Hpbar : MonoBehaviour {
    //�ő�HP�ƌ��݂�HP�B
    int maxHp = 100;
    int currentHp;
    //Slider�擾
    public Slider slider;

    void Start() {
    
        //Slider�𖞃^���ɂ���B
        slider.value = 1;
        //���݂�HP���ő�HP�Ɠ����ɁB
        currentHp = maxHp;
        Debug.Log("Start currentHp : " + currentHp);
    }


    public void Attack(int hp) { 

            //�ő�HP�ɂ����錻�݂�HP��Slider�ɔ��f�B
            //int���m�̊���Z�͏����_�ȉ���0�ɂȂ�̂ŁA
            //(float)������float�̕ϐ��Ƃ��ĐU���킹��B
            slider.value = (float)hp /(float)maxHp ;
            Debug.Log("slider.value : " + slider.value);
        }
    }
