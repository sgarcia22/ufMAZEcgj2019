using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveable : Interactable
{

    // How close a player needs to be before the interaction prompt appears.
    [SerializeField] private float radius = 3f;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject interactionPrompt;
    [SerializeField] private GameObject moveableObject;
    [SerializeField] private Vector3 translationToApply;
    [SerializeField] private Vector3 rotationToApply;
    [SerializeField] private bool moved = false;

    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            Debug.Log("No player assigned.");
            Destroy(this);
        }
        interactionPrompt.SetActive(false);
    }

    void Update()
    {
        if (PlayerWithinRadius() && interactionPrompt != null)
        {
            interactionPrompt.SetActive(true);
            player.GetComponent<PlayerController>().setInteractableWithinReach(this);
        }
        else
        {
            interactionPrompt.SetActive(false);
            player.GetComponent<PlayerController>().removeInteractableWithinReach(this);
        }
    }

    public override void Interact()
    {
        // Toggles the current interaction.
        if (moved)
        {
            moveableObject.transform.Translate(-1 * translationToApply);
            moveableObject.transform.Rotate(-1 * rotationToApply);
        }
        else
        {
            moveableObject.transform.Translate(translationToApply);
            moveableObject.transform.Rotate(rotationToApply);
        }
        moved = !moved;
    }

    public override bool PlayerWithinRadius()
    {
        Vector3 playerPosition = player.transform.position;
        Vector3 interactablePosition = this.transform.position;

        float distanceToPlayer = Mathf.Sqrt(Mathf.Pow(playerPosition.x - interactablePosition.x, 2) + Mathf.Pow(playerPosition.y - interactablePosition.y, 2) + Mathf.Pow(playerPosition.z - interactablePosition.z, 2));
        if (distanceToPlayer < radius)
        {
            return true;
        }
        return false;
    }
}
