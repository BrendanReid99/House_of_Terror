using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRaycast : MonoBehaviour
{
    [SerializeField] private int rayLength = 5;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private string excludeLayerName = null;

    private RaycastController raycastedObj;

   // [SerializeField] private GameObject player;
    [SerializeField] private KeyCode interactKey = KeyCode.Mouse0;

    private bool doOnce;

    private const string interactableTag = "Door";

    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;

        if (Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
        {
            if (hit.collider.CompareTag(interactableTag))

            {
                raycastedObj = hit.collider.gameObject.GetComponent<RaycastController>();

                if (Input.GetKeyDown(interactKey))
                {
                    raycastedObj.PlayDoorAnimation();
                }
            }
        }
    }

}
