using Fusion;
using UnityEngine;

public class PlayerMovementNoJump : NetworkBehaviour
{
    private CharacterController _controller;

    public float PlayerSpeed = 2f;
    private Transform cameraTransform; // Variable für die Kamera-Transform-Komponente

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        

        // Findet das Kamera-GameObject nach dem Namen und speichert die Transform-Komponente
        cameraTransform = Camera.main.transform;
    }

    public override void FixedUpdateNetwork()
    {
        // Nur den eigenen Spieler bewegen und nicht jeden anderen Spieler.
        if (HasStateAuthority == false)
        {
            return;
        }

        

    

       
        
        transform.position = cameraTransform.position + new Vector3(0, 1, 0) * Time.deltaTime;
        
        // Bewegen des Charakters
        _controller.Move(transform.position);
    }
}