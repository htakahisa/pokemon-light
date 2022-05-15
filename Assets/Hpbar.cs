using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI使うときは忘れずに。
using UnityEngine.UI;

public class Hpbar : MonoBehaviour {
    //最大HPと現在のHP。
    int maxHp = 100;
    int currentHp;
    //Slider取得
    public Slider slider;

    void Start() {
    
        //Sliderを満タンにする。
        slider.value = 1;
        //現在のHPを最大HPと同じに。
        currentHp = maxHp;
        Debug.Log("Start currentHp : " + currentHp);
    }


    public void Attack(int hp) { 

            //最大HPにおける現在のHPをSliderに反映。
            //int同士の割り算は小数点以下は0になるので、
            //(float)をつけてfloatの変数として振舞わせる。
            slider.value = (float)hp /(float)maxHp ;
            Debug.Log("slider.value : " + slider.value);
        }
    }
