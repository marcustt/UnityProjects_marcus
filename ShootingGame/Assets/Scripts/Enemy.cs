using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    Transform tr;

    private void Awake()
    {
        tr = gameObject.GetComponent<Transform>();

    }
    
    void Update()
    {
        Move();
    } //update 함수 종료

    private void Move()
    {
        Vector3 deltaMove = Vector3.back * speed * Time.deltaTime;
        tr.Translate(deltaMove, Space.World);
    } //move 함수 종료 
    private void OnCollisionEnter(Collision collision)
    {
        //총알이 부딪혔다면 두 오브젝트를 모두 파괴한다. 
        if(collision.gameObject.layer == LayerMask.NameToLayer("PlayerWeapon") )
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);

        }
    }
}
