using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // ���۸� ���� ���콺 Ŀ�� �̵� �ڵ� ���� mainCamera ���� reference error ��
    /* public Camera mainCamera; // ���� ī�޶�
    public float maxSpeed; // �ִ� �ӵ�
    public float aclrt; // ���ӵ�

    private float curr_speed; // ���� �ӵ� */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���콺 Ŀ�� ���� player �����̱�
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x, mousePos.y, 0);
        /*if (Input.GetMouseButton (0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast (ray, out hit, Mathf.Infinity))
            {
                Vector3 dir = new Vector3(hit.point.x - transform.position.x, 0f, hit.point.z - transform.position.z); // ���� ���ϱ�
                curr_speed = Mathf.Clamp(curr_speed += aclrt * Time.deltaTime, 0f, maxSpeed); // ����
                transform.rotation = Quaternion.LookRotation(dir); // ���� ����
            }
        } else
        {
            curr_speed = Mathf.Clamp(curr_speed -= aclrt * Time.deltaTime, 0f, maxSpeed); // ����
        }

        transform.Translate(Vector3.forward * curr_speed * Time.deltaTime);*/
    }
}
