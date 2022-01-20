using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Transform tr;
    public float moveSpeed; //변수를 마우스로 두번 클릭수 ctrl + r r 하면 변수 이름을 한번에 같이 변경할수 있다. 
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        tr = transform.gameObject.GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h,0,v).normalized;
        Vector3 moveVec = dir * moveSpeed * Time.deltaTime;

        tr.Translate(moveVec);

        float r = Input.GetAxis("Mouse X");
        Vector3 rotateVec = new Vector3(0, r, 0) * rotateSpeed * Time.deltaTime;
        tr.Rotate(rotateVec);




    }
}
