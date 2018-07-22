using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballIndicator : MonoBehaviour
{
    [SerializeField]

    private Camera _camera;

    public Texture2D aim;
    // Use this for initialization
    void Start()
    {
        _camera = GetComponent<Camera>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void OnGUI()
    {


        GUI.DrawTexture(new Rect(_camera.pixelWidth / 2 - 20, _camera.pixelHeight / 2 - 20, aim.width, aim.height), aim);
    }

    private IEnumerator SphereIndicator(Vector3 pos)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = pos;

        yield return new WaitForSeconds(1);
        Destroy(sphere);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector3 point = new Vector3(_camera.pixelWidth / 2 + 10, _camera.pixelHeight / 2 - 10, 0);
            Ray ray = _camera.ScreenPointToRay(point);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                StartCoroutine(SphereIndicator(hit.point));
            }
        }
    }



}
