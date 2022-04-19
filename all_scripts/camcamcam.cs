using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camcamcam : MonoBehaviour
{
    static public int x;
    static public float camspeed = 0.125F;
    [SerializeField] private GameObject[] _object; 
    [SerializeField] private Vector3 _distanceFromObject;
    private Quaternion _quaternion;
    Event function;
    void Start()
    {
        _distanceFromObject = transform.position - _object[0].transform.position;
        _quaternion = transform.rotation;
    }
    
    private void LateUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
            CameraFF();
        else
        Camera();
        //transform.LookAt(_object.transform.position); //Camera will look(returns) to the object
    }

    public void Camera()
    {
        Vector3 positionToGo = _object[x].transform.position + _distanceFromObject; //Target position of the camera
        Vector3 smoothPosition = Vector3.Lerp(a: transform.position, b: positionToGo, t: camspeed); //Smooth position of the camera
        transform.position = smoothPosition;
        transform.rotation = _quaternion;
    }

    public void CameraFF()
    {
        Vector3 high = new Vector3(0, (x == 0 ? 3 : 1), 0);
        Quaternion qua = Quaternion.Lerp(transform.rotation, _object[x].transform.rotation, 0.125f);
        Vector3 pos = Vector3.Lerp(transform.position, _object[x].transform.position + high, 0.125f);
        transform.position = pos;
        transform.rotation = qua;
    }
}
