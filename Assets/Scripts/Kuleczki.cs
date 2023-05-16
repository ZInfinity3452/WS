using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kuleczki : MonoBehaviour
{
    [SerializeField] PortalColor pc;
    RaycastHit targett;
    public gracz_strza³ tak;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        if (Physics.Raycast(transform.position, collision.contacts[0].point - transform.position, out targett))
        {
            tak.AnotherOne(pc, targett);
            
        }
        
    }
    private void OnEnable() 
    {
        tak = FindObjectOfType<gracz_strza³>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
