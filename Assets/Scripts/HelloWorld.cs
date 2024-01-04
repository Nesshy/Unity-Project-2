using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    string sayiString = " ";
    string ikiString = " ";
    string ucString = " ";
    string dortString = " ";
    string besString = "  ";
    ArrayList sayiList = new ArrayList();
    ArrayList ikiList = new ArrayList();
    ArrayList ucList = new ArrayList();
    ArrayList dortList = new ArrayList();
    ArrayList besList = new ArrayList();
    public void bolenleribul(int birincisayi, int ikincisayi)
    {/*
        */
        if (birincisayi < ikincisayi)
        {
            for (int i=birincisayi;i<=ikincisayi; i++)
            {
                sayiList.Add(i);
                if (i % 2 == 0)
                {
                    ikiList.Add(i);
                }
                if (i % 3 == 0)
                {
                    ucList.Add(i);
                }
                if (i % 4 == 0)
                {
                    dortList.Add(i);
                }
                if (i % 5 == 0)
                {
                    besList.Add(i);
                }
            }
            foreach (int eleman in sayiList)
            {
                sayiString += " " + eleman;
            }
            foreach (int eleman in ikiList)
            {
                ikiString += " " + eleman;
            }
            foreach (int eleman in ucList)
            {
                ucString += " " + eleman;
            }
            foreach (int eleman in dortList)
            {
                dortString += " " + eleman;
            }
            foreach (int eleman in besList)
            {
                besString += " " + eleman;
            }
            print(birincisayi +" ve "+ ikincisayi + " arasindaki tüm sayilar : " + sayiString);
            print(birincisayi + " ve " + ikincisayi + " arasindaki 2'ye tam bolunen sayilar : " + ikiString);
            print(birincisayi + " ve " + ikincisayi + " arasindaki 3'e tam bolunen sayilar : " + ucString);
            print(birincisayi + " ve " + ikincisayi + " arasindaki 4'e tam bolunen sayilar : " + dortString);
            print(birincisayi + " ve " + ikincisayi + " arasindaki 5'e tam bolunen sayilar : " + besString);
        }
        else if (birincisayi > ikincisayi)
        {
            for (int i = ikincisayi;i<birincisayi;  i++)
            {
                sayiList.Add(i);
                if (i % 2 == 0)
                {
                    ikiList.Add(i);
                }
                if (i % 3 == 0)
                {
                    ucList.Add(i);
                }
                if (i % 4 == 0)
                {
                    dortList.Add(i);
                }
                if (i % 5 == 0)
                {
                    besList.Add(i);
                }
            }
            foreach (int eleman in sayiList)
            {
                sayiString += " " + eleman;
            }
            foreach (int eleman in ikiList)
            {
                ikiString += " " + eleman;
            }
            foreach (int eleman in ucList)
            {
                ucString += " " + eleman;
            }
            foreach (int eleman in dortList)
            {
                dortString += " " + eleman;
            }
            foreach (int eleman in besList)
            {
                besString += " " + eleman;
            }
            print(birincisayi + " ve " + ikincisayi + " arasindaki tüm sayilar : " + sayiString);
            print(birincisayi + " ve " + ikincisayi + " arasindaki 2'ye tam bolunen sayilar : " + ikiString);
            print(birincisayi + " ve " + ikincisayi + " arasindaki 3'e tam bolunen sayilar : " + ucString);
            print(birincisayi + " ve " + ikincisayi + " arasindaki 4'e tam bolunen sayilar : " + dortString);
            print(birincisayi + " ve " + ikincisayi + " arasindaki 5'e tam bolunen sayilar : " + besString);
        }
        else
        {
            print("Sayilar esit");
        }
    }
    void Start()
    {
        bolenleribul(10, 20);
    }

    void Update()
    {
       
    }

}
