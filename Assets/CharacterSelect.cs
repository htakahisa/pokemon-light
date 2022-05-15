using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Onclick() {

        //chara = FindObjectOfType<player1>().character;
        FindObjectOfType<kantoku>().Character(name);
        //chara = name;
        SceneManager.LoadScene("Battle");
    }
}
