using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRHandTracking : MonoBehaviour
{
    public Transform leftHandTarget;
    public Transform rightHandTarget;
    public GameObject leftControllerObject; // Wir verwenden jetzt GameObject
    public GameObject rightControllerObject; // Wir verwenden jetzt GameObject

    private XRBaseController leftController;
    private XRBaseController rightController;

    void Start()
    {
        // Wir finden die XRController-Komponente zur Laufzeit
        if (leftControllerObject != null)
        {
            leftController = leftControllerObject.GetComponent<XRBaseController>();
            if (leftController == null)
            {
                Debug.LogError("Left Controller XRBaseController component not found!");
            }
        }
        else
        {
            Debug.LogError("Left Controller Object is not assigned!");
        }

        if (rightControllerObject != null)
        {
            rightController = rightControllerObject.GetComponent<XRBaseController>();
            if (rightController == null)
            {
                Debug.LogError("Right Controller XRBaseController component not found!");
            }
        }
        else
        {
            Debug.LogError("Right Controller Object is not assigned!");
        }
    }

    void Update()
    {
        if (leftController != null)
        {
            leftHandTarget.position = leftController.transform.position;
            leftHandTarget.rotation = leftController.transform.rotation;
        }

        if (rightController != null)
        {
            rightHandTarget.position = rightController.transform.position;
            rightHandTarget.rotation = rightController.transform.rotation;
        }
    }
}
