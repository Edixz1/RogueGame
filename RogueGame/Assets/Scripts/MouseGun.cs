using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class MouseGun : MonoBehaviour
{
    private Transform armsTrans;
    private Vector3 mousePos;
    private void Awake()
    {
        //armsTrans = transform.Find("arms");

    }
    private void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
    }
    private void FixedUpdate()
    {
        /* Vector3 differance = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        differance.Normalize();
        float rotationZ = Mathf.Atan2(differance.y, differance.x) * Mathf.Rad2Deg - 90f;

        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
       

        Vector2 armsDirection = mousePos - transform.position;
        float angle = Mathf.Atan2(armsDirection.y, armsDirection.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle);
        Debug.Log(angle);*/
    }
    /* 
     private Vector3 GetMousePosition()
     {
         Vector3 vec = GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
         vec.z = 0f;
         return vec;
     }

     private Vector3 GetMouseWorldPositionWithZ() => GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
     private Vector3 GetMouseWorldPositionWithZ(Camera worldCamera) => GetMouseWorldPositionWithZ(Input.mousePosition, worldCamera);
     private Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition, Camera worldCamera)
     {
         Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
         return worldPosition;
     }*/
}
