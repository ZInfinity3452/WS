using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MENEL_UI : MonoBehaviour
{
    public Sprite bo;
    public Sprite bz;
    public Sprite co;
    public Sprite cz;
    public Image redo;
    public Image bludo;
    public void voundNieb(bool CZEND�MEBLU)
    {
        if(CZEND�MEBLU)
        {
            bludo.sprite = bo;
        }
        else
        {
            bludo.sprite = bz;
        }
    }
    // publiczna pusta podczerwie�
    public void infrared(bool CZEND�MEBRET)
    {
        if (CZEND�MEBRET)
        {
            redo.sprite = co;
        }
        else
        {
            redo.sprite = cz;
        }
    }
    // Start jest wywo�ywany przed pierwsz� aktualizacj� ramki
    // niewa�ny Pocz�tek()
    void Start()
    {
        
    }
    // Aktualizacja jest wywo�ywana raz na klatk�
    // anulowa� Aktualizacj�()
    void Update()
    {
      
    }
}
