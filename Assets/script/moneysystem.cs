using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class moneysystem : MonoBehaviour
{
    public Text textmoney;
    public float money;
    public int index;
    public Pause pause;
    // Start is called before the first frame update
    public void Start()
    {
        money =0;
        UpdateMoney();
        textmoney.text = (money).ToString() + '$';
        index = SceneManager.GetActiveScene().buildIndex;
    }
    public void Update()
    {
        if (money>5000 && index == 1)
        {
            SceneManager.LoadScene(4);
        }
        if (money > 5000 && index == 2)
        {
            SceneManager.LoadScene(5);
        }
        if (money > 5000 && index == 3)
        {
            SceneManager.LoadScene(6);
        }
    }

    public void UpdateMoney()
    {


        textmoney.text = (money).ToString() + '$'+'/'+5000;
    }
    public void moneyreceive(float moneyrec)
    {
        if (pause.moneystop == false)
        {
            money += moneyrec;
            //Debug.Log("money"+money);
            UpdateMoney();
        }
       
      
    }
}
