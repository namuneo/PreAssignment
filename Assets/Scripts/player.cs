using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // 구글링 통해 마우스 커서 이동 코드 실패 mainCamera 관련 reference error 뜸
    /* public Camera mainCamera; // 메인 카메라
    public float maxSpeed; // 최대 속도
    public float aclrt; // 가속도

    private float curr_speed; // 현재 속도 */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 커서 따라 player 움직이기
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x, mousePos.y, 0);
        /*if (Input.GetMouseButton (0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast (ray, out hit, Mathf.Infinity))
            {
                Vector3 dir = new Vector3(hit.point.x - transform.position.x, 0f, hit.point.z - transform.position.z); // 방향 구하기
                curr_speed = Mathf.Clamp(curr_speed += aclrt * Time.deltaTime, 0f, maxSpeed); // 가속
                transform.rotation = Quaternion.LookRotation(dir); // 방향 설정
            }
        } else
        {
            curr_speed = Mathf.Clamp(curr_speed -= aclrt * Time.deltaTime, 0f, maxSpeed); // 감속
        }

        transform.Translate(Vector3.forward * curr_speed * Time.deltaTime);*/
    }
}
