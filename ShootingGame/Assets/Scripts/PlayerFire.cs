using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePoint;

    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //gameobject 의 인스턴스화 
            GameObject tmpBullet = Instantiate(bullet, firePoint);
        }
    }
}
