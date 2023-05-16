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
    public void voundNieb(bool CZEND¯MEBLU)
    {
        if(CZEND¯MEBLU)
        {
            bludo.sprite = bo;
        }
        else
        {
            bludo.sprite = bz;
        }
    }
    // publiczna pusta podczerwieñ
    public void infrared(bool CZEND¯MEBRET)
    {
        if (CZEND¯MEBRET)
        {
            redo.sprite = co;
        }
        else
        {
            redo.sprite = cz;
        }
    }
    // Start jest wywo³ywany przed pierwsz¹ aktualizacj¹ ramki
    // niewa¿ny Pocz¹tek()
    void Start()
    {
        
    }
    // Aktualizacja jest wywo³ywana raz na klatkê
    // anulowaæ Aktualizacjê()
    void Update()
    {
      
    }
}
