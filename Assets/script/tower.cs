using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tower : MonoBehaviour
{
    public Ray ray;
    public Camera main_camera;
    public GameObject tower1;
    public GameObject tower2;
    public GameObject tower3;
    public GameObject tower4;
    public GameObject tower5;
    public GameObject tower6;
    public GameObject tower7;
    public GameObject tower8;
    public GameObject tower9;
    public GameObject tower10;

    public GameObject gun1;
    public GameObject gun2;
    public GameObject gun3;
    public GameObject gun4;
    public GameObject gun5;
    public GameObject gun6;
    public GameObject gun7;
    public GameObject gun8;
    public GameObject gun9;
    public GameObject gun10;

    public GameObject rocket1;
    public GameObject rocket2;
    public GameObject rocket3;
    public GameObject rocket4;
    public GameObject rocket5;
    public GameObject rocket6;
    public GameObject rocket7;
    public GameObject rocket8;
    public GameObject rocket9;
    public GameObject rocket10;

    public moneysystem moneysys;
    public int money;
    public void Start()
    {

    }
    public void Update()
    {

      
        // Update is called once per frame
        if (Input.GetMouseButtonDown(0))
        {
            
            ray = main_camera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit[] raycasthit = Physics.RaycastAll(ray, 50);
           
            
            for (int i = 0; i < raycasthit.Length; i++)
            {
                print(raycasthit[i].collider.tag);
                print(raycasthit[i].point);


                if (raycasthit[i].collider.CompareTag("towerbuild1") && moneysys.money >= 0)

                {
                    gun1.SetActive(false);
                    rocket1.SetActive(true);
                    moneysys.moneyreceive(-5);
                    raycasthit[i].collider.tag = "nothing";
                }
                if (raycasthit[i].collider.CompareTag("towerbuild2") && moneysys.money >= 0)

                {
                    gun2.SetActive(false);
                    rocket2.SetActive(true);
                    moneysys.moneyreceive(-5);
                    raycasthit[i].collider.tag = "nothing";
                }
                if (raycasthit[i].collider.CompareTag("towerbuild3") && moneysys.money >= 0)

                {
                    gun3.SetActive(false);
                    rocket3.SetActive(true);
                    moneysys.moneyreceive(-5);
                    raycasthit[i].collider.tag = "nothing";
                }
                if (raycasthit[i].collider.CompareTag("towerbuild4") && moneysys.money >= 0)

                {
                    gun4.SetActive(false);
                    rocket4.SetActive(true);
                    moneysys.moneyreceive(-5);
                    raycasthit[i].collider.tag = "nothing";
                }
                if (raycasthit[i].collider.CompareTag("towerbuild5") && moneysys.money >= 0)

                {
                    gun5.SetActive(false);
                    rocket5.SetActive(true);
                    moneysys.moneyreceive(-5);
                    raycasthit[i].collider.tag = "nothing";
                }
                if (raycasthit[i].collider.CompareTag("towerbuild6") && moneysys.money >= 0)

                {
                    gun6.SetActive(false);
                    rocket6.SetActive(true);
                    moneysys.moneyreceive(-5);
                    raycasthit[i].collider.tag = "nothing";
                }
                if (raycasthit[i].collider.CompareTag("towerbuild7") && moneysys.money >= 0)

                {
                    gun7.SetActive(false);
                    rocket7.SetActive(true);
                    moneysys.moneyreceive(-5);
                    raycasthit[i].collider.tag = "nothing";
                }
                if (raycasthit[i].collider.CompareTag("towerbuild8") && moneysys.money >= 0)

                {
                    gun8.SetActive(false);
                    rocket8.SetActive(true);
                    moneysys.moneyreceive(-5);
                    raycasthit[i].collider.tag = "nothing";
                }
                if (raycasthit[i].collider.CompareTag("towerbuild9") && moneysys.money >= 0)

                {
                    gun9.SetActive(false);
                    rocket9.SetActive(true);
                    moneysys.moneyreceive(-5);
                    raycasthit[i].collider.tag = "nothing";
                }
                if (raycasthit[i].collider.CompareTag("towerbuild10") && moneysys.money >= 0)

                {
                    gun10.SetActive(false);
                    rocket10.SetActive(true);
                    moneysys.moneyreceive(-5);
                    raycasthit[i].collider.tag = "nothing";
                }

                if (raycasthit[i].collider.CompareTag("towerplace1")&&moneysys.money>=0)

                {

                    Debug.Log(raycasthit[i].collider);
                    tower1.SetActive(true);
                    rocket1.SetActive(false);
                    moneysys.moneyreceive(-200);
                    raycasthit[i].collider.tag = "towerbuild1";


                }


                if (raycasthit[i].collider.CompareTag("towerplace2")&&moneysys.money >=0)

                {
                   
                    Debug.Log(raycasthit[i].collider);
                    tower2.SetActive(true);
                    rocket2.SetActive(false);
                    moneysys.moneyreceive(-200);
                    raycasthit[i].collider.tag = "towerbuild2";
                }


                if (raycasthit[i].collider.CompareTag("towerplace3") && moneysys.money >=0)

                {
                    Debug.Log(raycasthit[i].collider);
                    tower3.SetActive(true);
                    rocket3.SetActive(false);
                    moneysys.moneyreceive(-200);
                    raycasthit[i].collider.tag = "towerbuild3";
                }
                if (raycasthit[i].collider.CompareTag("towerplace4") && moneysys.money >=0)

                {
                    Debug.Log(raycasthit[i].collider);
                    tower4.SetActive(true);
                    rocket4.SetActive(false);
                    moneysys.moneyreceive(-200);
                    raycasthit[i].collider.tag = "towerbuild4";
                }
                if (raycasthit[i].collider.CompareTag("towerplace5") && moneysys.money >=0)

                {
                    Debug.Log(raycasthit[i].collider);
                    tower5.SetActive(true);
                    rocket5.SetActive(false);
                    moneysys.moneyreceive(-200);
                    raycasthit[i].collider.tag = "towerbuild5";
                }

                if (raycasthit[i].collider.CompareTag("towerplace6") && moneysys.money >=0)

                {
                    Debug.Log(raycasthit[i].collider);
                    tower6.SetActive(true);
                    rocket6.SetActive(false);
                    moneysys.moneyreceive(-200);
                    raycasthit[i].collider.tag = "towerbuild6";
                }
                if (raycasthit[i].collider.CompareTag("towerplace7") && moneysys.money >=0)

                {
                    Debug.Log(raycasthit[i].collider);
                    tower7.SetActive(true);
                    rocket7.SetActive(false);
                    moneysys.moneyreceive(-200);
                    raycasthit[i].collider.tag = "towerbuild7";
                }
                if (raycasthit[i].collider.CompareTag("towerplace8") && moneysys.money >=0)

                {
                    Debug.Log(raycasthit[i].collider);
                    tower8.SetActive(true);
                    rocket8.SetActive(false);
                    moneysys.moneyreceive(-200);
                    raycasthit[i].collider.tag = "towerbuild8";
                }
                if (raycasthit[i].collider.CompareTag("towerplace9") && moneysys.money >=0)

                {
                    Debug.Log(raycasthit[i].collider);
                    tower9.SetActive(true);
                    rocket9.SetActive(false);
                    moneysys.moneyreceive(-200);
                    raycasthit[i].collider.tag = "towerbuild9";
                }
                if (raycasthit[i].collider.CompareTag("towerplace10") && moneysys.money >=0)

                {
                    Debug.Log(raycasthit[i].collider);
                    tower10.SetActive(true);
                    rocket10.SetActive(false);
                    moneysys.moneyreceive(-200);
                    raycasthit[i].collider.tag = "towerbuild10";
                }




            }

        }
    }
}
