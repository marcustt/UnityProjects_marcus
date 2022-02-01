using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed =3f;
    Transform tr;

    void Start()
    {
        tr = gameObject.GetComponent<Transform>();

        Destroy(gameObject, 5f); //5초뒤에 탄알파괴
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        
        
        Vector3 deltaMove = Vector3.forward * speed * Time.deltaTime;
        
        tr.Translate(deltaMove,Space.World);

    }
}
