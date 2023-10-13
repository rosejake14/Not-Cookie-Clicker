//Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Manager : MonoBehaviour
{
    //Public Variables.   All numbers are subject to change.
    float TotalClicks;
    public int cps;
    public int level = 0;
    public bool clickupgraded = false;

    //References.
    public Text ClicksTotalText;
    public GameObject UpgradeButton1;
    public GameObject UpgradeButton2;
    public GameObject UpgradeButton3;
    public GameObject UpgradeButton4;
    public GameObject upgimg1;
    public GameObject upgimg2;
    public GameObject upgimg3;
    public GameObject upgimg4;
    public GameObject clickerUpgrade;
    public GameObject Jeff;
    public GameObject FinalCake;
    public GameObject FinalScreen;

    void Start()
    {
        upgimg1.SetActive(false);
        upgimg2.SetActive(false);
        upgimg3.SetActive(false);
        upgimg4.SetActive(false);
        Jeff.SetActive(false);
        FinalCake.SetActive(false);
        FinalScreen.SetActive(false);
    }

    public void AddClicks() //This is run on ever main click from the user to increase by 1.
{
    TotalClicks++;
    if (clickupgraded == true){
        TotalClicks += 50;
    }
    if(TotalClicks >= 69){
        Jeff.SetActive(true);
    }
    ClicksTotalText.text = TotalClicks.ToString("0"); //Updates value of points.
    
}

    public void ClickUpgrade(){
        if(TotalClicks >= 1250)
        {
            clickupgraded = true;
            clickerUpgrade.SetActive(false);
            TotalClicks -= 1250;
            FinalCake.SetActive(true);
        }
    }

    public void Upgrade()  //Each upgrade will increase the level which increases passive income.
{
    if(TotalClicks >= 15)
    {
        TotalClicks -= 15;
        level += 1;
        UpgradeButton1.SetActive(false); //Removes Button
        upgimg1.SetActive(true);
        Upgrade();
    }
}
    public void Upgrade2()
{
    if(TotalClicks >= 50)
    {
        TotalClicks -= 50;
        level += 2;
        UpgradeButton2.SetActive(false);
        upgimg2.SetActive(true);
        Upgrade();
    }
}
    public void Upgrade3()
{
    if(TotalClicks >= 100)
    {
        TotalClicks -= 100;
        level += 3;
        UpgradeButton3.SetActive(false);
        upgimg3.SetActive(true);
        Upgrade();
    }
}
    public void Upgrade4()
{
    if(TotalClicks >= 500)
    {
        TotalClicks -= 500;
        level += 5;
        UpgradeButton4.SetActive(false);
        upgimg4.SetActive(true);
        Upgrade();
    }
}

    public void FinalCakeUpgrade(){
        if(TotalClicks >= 2500){
            FinalScreen.SetActive(true);
            Text();
            Application.Quit();
        }
    }

    IEnumerator Text() 
    {
        yield return new WaitForSeconds(30); //https://www.codegrepper.com/code-examples/csharp/wait+3+seconds+unity
    }

    public void Update()
    {
            TotalClicks += level * Time.deltaTime; //Increases points using Time and level.
            //TotalClicks += level;
            ClicksTotalText.text = TotalClicks.ToString("0");
            //Debug.Log(level);

            
    }


}


