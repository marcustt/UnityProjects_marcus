using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Transform tr;

    //serializeField 는 private 속성을 유지한채 인스펙터창에 노출해준다.
    [SerializeField] private float speed;

    private void Awake()
    {
        tr = gameObject.GetComponent<Transform>();

    }

    void Start()
    {
        
    }

    
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); //수평움직임감지
        float z = Input.GetAxis("Vertical");    //수직움직임감지
        //normalized 벡터의 방향은 같고 길이가 1인 벡터를 반환해준다. 
        Vector3 dir = new Vector3(h, 0, z).normalized;
        Vector3 deltaMove = dir * speed * Time.deltaTime; //이동 변화량

        tr.Translate(deltaMove);

    }//update 함수 종료

    public void Die()
    {
        gameObject.SetActive(false);
    }//die 함수 종료

}
