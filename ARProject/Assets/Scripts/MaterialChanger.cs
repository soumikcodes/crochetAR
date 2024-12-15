using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MultiTargetMaterialChanger : MonoBehaviour
{
    public GameObject butterflyLeftWing;
    public GameObject butterflyRightWing;
    public Material newMaterial;

    private bool multiTargetDetected = false;

    void Start()
    {
        ObserverBehaviour observerBehaviour = GetComponent<ObserverBehaviour>();
        if (observerBehaviour != null)
        {
            // Register for status change events
            observerBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }
        else
        {
            Debug.LogError("ObserverBehaviour not found on this GameObject.");
        }
    }

    void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        // Check if the multi-target is detected
        if (targetStatus.Status == Status.TRACKED || targetStatus.Status == Status.EXTENDED_TRACKED)
        {
            if (!multiTargetDetected)
            {
                multiTargetDetected = true;
                ChangeButterflyMaterial();
            }
        }
        else
        {
            multiTargetDetected = false;
        }
    }

    void ChangeButterflyMaterial()
    {
        if (butterflyLeftWing != null && newMaterial != null)
        {
            // Find all MeshRenderers in the children of the butterfly object
            MeshRenderer[] meshRenderers = butterflyLeftWing.GetComponentsInChildren<MeshRenderer>();

            // Loop through each MeshRenderer and change its material
            foreach (MeshRenderer meshRenderer in meshRenderers)
            {
                meshRenderer.material = newMaterial;
            }
        }
        else
        {
            Debug.LogError("ButterflyObject or NewMaterial is not assigned.");
        }

        if (butterflyRightWing != null && newMaterial != null)
        {
            // Find all MeshRenderers in the children of the butterfly object
            MeshRenderer[] meshRenderers = butterflyRightWing.GetComponentsInChildren<MeshRenderer>();

            // Loop through each MeshRenderer and change its material
            foreach (MeshRenderer meshRenderer in meshRenderers)
            {
                meshRenderer.material = newMaterial;
            }
        }
        else
        {
            Debug.LogError("ButterflyObject or NewMaterial is not assigned.");
        }
    }

    void OnDestroy()
    {
        // Unregister callbacks to avoid memory leaks
        ObserverBehaviour observerBehaviour = GetComponent<ObserverBehaviour>();
        if (observerBehaviour != null)
        {
            observerBehaviour.OnTargetStatusChanged -= OnTargetStatusChanged;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
